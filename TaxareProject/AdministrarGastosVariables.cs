using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CT = Controllers;
using EN = Entities;
using BR = Broker;

namespace TaxareProject
{
    public partial class AdministrarGastosVariables : Form

    {
        CT.GastosVariables gastosVariablesController = new CT.GastosVariables();
        CT.Kilometraje kilometrajeController = new CT.Kilometraje();
        CT.Taxis taxisController = new CT.Taxis();


        public AdministrarGastosVariables()
        {
            InitializeComponent();
            LlenarTaxis();
            llenarDataGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void llenarDataGridView()
        {

            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = gastosVariablesController.gastosVariables();

        }

        void LlenarTaxis()
        {
            List<EN.Taxis> listConductores = taxisController.MostrarTaxis();

            cmbTx.Items.Clear();

            foreach (EN.Taxis other in listConductores)
            {

                cmbTx.Items.Add(other.placa.Trim().ToUpper() + " " + other.marca.ToUpper());
            }

        }

        public void limpiar()
        {

            cmbTx.Text = rtxtDescripcion.Text = txtKilo.Text = txtValor.Text = "";

        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            if (cmbTx.Text.Length != 0 && rtxtDescripcion.Text.Length != 0 && rtxtDescripcion.Text.Length != 0 && txtKilo.Text.Length != 0 && txtValor.Text.Length != 0)
            {
                EN.GastosVariables GV = new EN.GastosVariables();
                GV.descripcion = rtxtDescripcion.Text.Trim();
                GV.fecha = dtpDate.Value.Date;
                GV.kilometraje = Convert.ToDouble(txtKilo.Text.Trim());
                String[] DataTaxi = cmbTx.Text.Split(' ');
                GV.placa = DataTaxi[0].Trim();
                GV.valor = Convert.ToDouble(txtValor.Text.Trim());
                kilometrajeController.ActualizarKilometraje(GV.placa, GV.kilometraje);
                if (gastosVariablesController.CrearGastoV(GV))
                {

                    MessageBox.Show("Se Añadio El Registro, Ahora el Vehiculo " + GV.placa + " tiene un gasto de: " + GV.valor + "$");
                    llenarDataGridView();
                    limpiar();

                }
                else
                {

                    MessageBox.Show("Verifique los datos");

                }

            }

            else
            {
                MessageBox.Show("Ocurio un error, intente de nuevo y verifique los datos");

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvGastos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvGastos.CurrentRow.Index != -1)
            {
                BR.GastosVariables other = gastosVariablesController.DevuelveGV(Convert.ToInt32(dgvGastos.CurrentRow.Cells["id"].Value));
                EN.Taxis t = taxisController.GetTaxi(other.placa);
                //Pintar los datos
                cmbTx.Text = (t.placa.Trim().ToUpper() + " " + t.marca.ToUpper());
                rtxtDescripcion.Text = other.descripcion.ToString();
                dtpDate.Value = other.fecha;
                txtKilo.Text = other.kilometraje.ToString();
                txtValor.Text = other.valor.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void dgvGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {

            if (cmbTx.Text.Length != 0 && rtxtDescripcion.Text.Length != 0 && rtxtDescripcion.Text.Length != 0 && txtKilo.Text.Length != 0 && txtValor.Text.Length != 0)
            {
                EN.GastosVariables GV = new EN.GastosVariables();
                String[] DataTaxi = cmbTx.Text.Split(' ');
                var other = gastosVariablesController.DevuelveGV(Convert.ToInt32(dgvGastos.CurrentRow.Cells["id"].Value));
                GV.descripcion = rtxtDescripcion.Text;
                GV.fecha = dtpDate.Value.Date;
                GV.kilometraje = Convert.ToDouble(txtKilo.Text.Trim());
                GV.placa = DataTaxi[0].Trim();
                GV.valor = Convert.ToDouble(txtValor.Text.Trim());
                kilometrajeController.ActualizarKilometraje(GV.placa, GV.kilometraje);

                if (gastosVariablesController.ActualizarGastosV(GV))
                {

                    MessageBox.Show("Se Actualizo el registro");
                    llenarDataGridView();
                    limpiar();

                }
                else
                {

                    MessageBox.Show("Verifique los datos");

                }

            }

            else
            {
                MessageBox.Show("Ocurio un error, intente de nuevo y verifique los datos");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio i = new Inicio();
            i.Show();
        }
    }
}

