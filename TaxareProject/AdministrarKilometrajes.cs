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
    public partial class AdministrarKilometrajes : Form
    {
        CT.Kilometraje kilometrajeController = new CT.Kilometraje();
        CT.Taxis taxisController = new CT.Taxis();
        CT.Marcas marcasController = new CT.Marcas();


        public AdministrarKilometrajes()
        {
            InitializeComponent();
            LlenarTaxis();
            llenarDataGridView();
        }

        void LlenarTaxis()
        {
            List<EN.Taxis> listConductores = taxisController.MostrarTaxis();

            cmbTx.Items.Clear();
            foreach (EN.Taxis b in listConductores)
            {

                cmbTx.Items.Add(b.placa.Trim().ToUpper() + " " + b.marca.ToUpper());
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpExpedicion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void llenarDataGridView()
        {

            dgvKilometrajes.AutoGenerateColumns = false;
            dgvKilometrajes.DataSource = kilometrajeController.ObtenerKilometrajes();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            if (cmbTx.Text.Length != 0 && txtKilo.Text.Length != 0 && dtpDate.Value.Date != null)
            {
                EN.Kilometrajes kilo = new EN.Kilometrajes();
                String[] DataTaxi = cmbTx.Text.Split(' ');
                kilo.placa = DataTaxi[0].Trim();
                kilo.kilometraje = Convert.ToInt32(txtKilo.Text);
                kilo.fecha = dtpDate.Value.Date;

                if (kilometrajeController.crearKilometraje(kilo))
                {
                    MessageBox.Show("Se Añadio el kilometraje al Vehiculo" + kilo.placa + "Con un kilometraje de " + kilo.kilometraje + "kms");
                    llenarDataGridView();
                }

            }
            else
            {

                MessageBox.Show("Revise los datos e intente de nuevo");

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvKilometrajes.CurrentRow.Index != -1))
            {
                long id = Convert.ToInt64(dgvKilometrajes.CurrentRow.Cells["id"].Value);

                if (kilometrajeController.eliminarKilometraje(id))
                {
                    MessageBox.Show("Se elimino el registro correctamente");
                    llenarDataGridView();
                }
                else
                {

                    MessageBox.Show("El registro no se encuentra o debe seleccionar uno");
                }
            }
        }

        private void AdministrarKilometrajes_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvKilometrajes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKilometrajes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvKilometrajes.CurrentRow.Index != -1)
            {
                EN.Kilometrajes k = kilometrajeController.ObtenerKilometraje(Convert.ToInt64(dgvKilometrajes.CurrentRow.Cells["Id"].Value));
                EN.Taxis t = taxisController.GetTaxi(k.placa);

                //Asignar valores 
                cmbTx.Text = (t.placa.Trim().ToUpper() + " " + t.marca.ToUpper());
                txtKilo.Text = k.kilometraje.ToString();
                dtpDate.Value = k.fecha;
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            //Claves foraneas 
            String[] DataTaxi = cmbTx.Text.Split(' ');
            String placa = DataTaxi[0].Trim();

            if (placa.Length != 0 && (dgvKilometrajes.CurrentRow.Index != -1) && txtKilo.Text.Length != 0)
            {

                EN.Kilometrajes a = new EN.Kilometrajes();
                a.id = kilometrajeController.ObtenerIDKilometraje(placa);
                a.placa = placa;
                a.kilometraje = Convert.ToDouble(txtKilo.Text);
                a.fecha = dtpDate.Value.Date;

                if (kilometrajeController.ActualizarKilometraje(a))
                {

                    MessageBox.Show("Se Actualizo El Registro, Ahora el Vehiculo " + a.placa + " Tiene  " + a.kilometraje + "kms Recorridos");
                    llenarDataGridView();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo y verifique lo datos");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbTx.Text = txtKilo.Text = " ";
        }

        private void AdministrarKilometrajes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio i = new Inicio();
            i.Show();
        }
    }
}


