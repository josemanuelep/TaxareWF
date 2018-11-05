using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxareProject
{
    public partial class AdministrarGastosVariables : Form

    {
        GastosVariable GV = new GastosVariable();
        Controladores.ControladoraGastosVariablescs controladora = new Controladores.ControladoraGastosVariablescs();
        Controladores.ControladoraKilometraje controlaKM = new Controladores.ControladoraKilometraje();
        Controladores.ControladorTaxis txs = new Controladores.ControladorTaxis();
        Controladores.ControladorMarcas mrks = new Controladores.ControladorMarcas();

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
            dgvGastos.DataSource = controladora.gastosVariables();

        }

        void LlenarTaxis()
        {
            List<Taxi> listConductores = txs.MostrarTaxis();

            cmbTx.Items.Clear();
            foreach (Taxi b in listConductores)
            {

                cmbTx.Items.Add(b.placa.Trim().ToUpper() + " " + mrks.MostrarMarca_String(b.id_marca).ToUpper());
            }

        }

        public void limpiar() {

            cmbTx.Text = rtxtDescripcion.Text = txtKilo.Text = txtValor.Text = "";

        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (cmbTx.Text.Length != 0 && rtxtDescripcion.Text.Length != 0 && rtxtDescripcion.Text.Length != 0 && txtKilo.Text.Length != 0 && txtValor.Text.Length != 0)
            {
                GV.descripcion = rtxtDescripcion.Text.Trim();
                GV.fecha = dtpDate.Value.Date;
                GV.kilometraje = Convert.ToDouble(txtKilo.Text.Trim());
                String[] DataTaxi = cmbTx.Text.Split(' ');
                GV.placa = DataTaxi[0].Trim();
                GV.valor = Convert.ToDouble(txtValor.Text.Trim());
                controlaKM.ActualizarKilometraje(GV.placa,GV.kilometraje);
                if (controladora.CrearGastoV(GV))
                {

                    MessageBox.Show("Se Añadio El Registro, Ahora el Vehiculo " + GV.placa + " tiene un gasto de: " + GV.valor + "$");
                    llenarDataGridView();
                    limpiar();

                }
                else {

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
                GastosVariable other = controladora.DevuelveGV(Convert.ToInt32(dgvGastos.CurrentRow.Cells["id"].Value));
                Taxi t = txs.GetTaxi(other.placa);
                //Pintar los datos
                cmbTx.Text = (t.placa.Trim().ToUpper() + " " + mrks.MostrarMarca_String(t.id_marca).ToUpper());
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
                String[] DataTaxi = cmbTx.Text.Split(' ');
                GV = controladora.DevuelveGV(Convert.ToInt32(dgvGastos.CurrentRow.Cells["id"].Value));
                GV.descripcion = rtxtDescripcion.Text;
                GV.fecha = dtpDate.Value.Date;
                GV.kilometraje = Convert.ToDouble(txtKilo.Text.Trim());
                GV.placa = DataTaxi[0].Trim();
                GV.valor = Convert.ToDouble(txtValor.Text.Trim());
                controlaKM.ActualizarKilometraje(GV.placa, GV.kilometraje);

                if (controladora.ActualizarGastosV(GV))
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
    }
}
