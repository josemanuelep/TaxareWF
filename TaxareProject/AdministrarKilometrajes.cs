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
    public partial class AdministrarKilometrajes : Form
    {
        Kilometraje kilo = new Kilometraje();
        Controladores.ControladoraKilometraje controladora = new Controladores.ControladoraKilometraje();
        Controladores.ControladorTaxis txs = new Controladores.ControladorTaxis();
        Controladores.ControladorMarcas mrks = new Controladores.ControladorMarcas();

        public AdministrarKilometrajes()
        {
            InitializeComponent();
            LlenarTaxis();
            llenarDataGridView();
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
            dgvKilometrajes.DataSource = controladora.ObtenerKilometrajes();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (cmbTx.Text.Length != 0 && txtKilo.Text.Length != 0 && dtpDate.Value.Date != null)
            {

                String[] DataTaxi = cmbTx.Text.Split(' ');
                kilo.placa = DataTaxi[0].Trim();
                kilo.kilometraje1 = Convert.ToInt32(txtKilo.Text);
                kilo.fecha = dtpDate.Value.Date;

                if (controladora.crearKilometraje(kilo))
                {
                    MessageBox.Show("Se Añadio el kilometraje al Vehiculo" + kilo.placa + "Con un kilometraje de " + kilo.kilometraje1 + "kms");
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

                if (controladora.eliminarKilometraje(id))
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
                Kilometraje k = controladora.ObtenerKilometraje(Convert.ToInt64(dgvKilometrajes.CurrentRow.Cells["Id"].Value));
                Taxi t = txs.GetTaxi(k.placa);

                //Asignar valores 
                cmbTx.Text = (t.placa.Trim().ToUpper() + " " + mrks.MostrarMarca_String(t.id_marca).ToUpper());
                txtKilo.Text = k.kilometraje1.ToString();
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

                Kilometraje a = new Kilometraje();
                a.id = controladora.ObtenerIDKilometraje(placa);
                a.placa = placa;
                a.kilometraje1 = Convert.ToDouble(txtKilo.Text);
                a.fecha = dtpDate.Value.Date;

                if (controladora.ActualizarKilometraje(a))
                {

                    MessageBox.Show("Se Actualizo El Registro, Ahora el Vehiculo " + a.placa + " Tiene  " + a.kilometraje1 + "kms Recorridos");
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
    }
}

