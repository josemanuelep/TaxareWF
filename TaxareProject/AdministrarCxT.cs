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
    public partial class AdministrarCxT : Form
    {
        CT.ConductoresXtaxis conductoresTaxisController = new CT.ConductoresXtaxis();
        CT.Conductores conductoresController = new CT.Conductores();
        CT.Taxis taxisController = new CT.Taxis();
        CT.Marcas marcasController = new CT.Marcas();

        public AdministrarCxT()
        {
            InitializeComponent();
        }

        private void AdministrarCxT_Load(object sender, EventArgs e)
        {
            LlenarConductores();
            LlenarTaxis();
            llenarDataGridView();

        }

        void llenarDataGridView()
        {

            dgvCxT.AutoGenerateColumns = false;
            dgvCxT.DataSource = conductoresTaxisController.ListaCT();

        }

        void LlenarConductores()
        {
            List<BR.Conductor> listConductores = conductoresController.MostrarConductores();

            cmbConductor.Items.Clear();

            foreach (BR.Conductor other in listConductores)
            {

                cmbConductor.Items.Add(other.cedula + " " + other.nombre.Trim() + " " + other.apellido.Trim());
            }

        }

        void LlenarTaxis()
        {
            List<EN.Taxis> listConductores = taxisController.MostrarTaxis();

            cmbTx.Items.Clear();

            foreach (EN.Taxis car in listConductores)
            {

                cmbTx.Items.Add(car.placa.Trim().ToUpper() + " " +car.marca.ToUpper());
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Claves foraneas para id
            String[] Dataconductor = cmbConductor.Text.Split(' ');
            String[] DataTaxi = cmbTx.Text.Split(' ');

            long idDriver = conductoresController.MostarIdConductor(Dataconductor[0].Trim());
            String placa = DataTaxi[0].Trim();

            if (idDriver != 0 && placa != null)
            {

                EN.ConductoresXtaxis conductoresXtaxis = new EN.ConductoresXtaxis();
                conductoresXtaxis.id = idDriver;
                conductoresXtaxis.placaTaxi = placa;
                if (conductoresTaxisController.CrearCT(conductoresXtaxis))
                {

                    MessageBox.Show("Se Añadio El Registro, Ahora el conductor " + Dataconductor[1] + " Conduce el vehiculo " + DataTaxi[0]);
                    llenarDataGridView();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo");
                }

            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvCxT.CurrentRow.Index != -1))
            {
                long id = Convert.ToInt64(dgvCxT.CurrentRow.Cells["Id"].Value);
                if (conductoresTaxisController.EliminarCT(id))
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbConductor.Text = cmbTx.Text = "";
            LlenarTaxis();
            LlenarConductores();
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            //Claves foraneas para id
            String[] Dataconductor = cmbConductor.Text.Split(' ');
            String[] DataTaxi = cmbTx.Text.Split(' ');

            long idDriver = conductoresController.MostarIdConductor(Dataconductor[0].Trim());
            String placa = DataTaxi[0].Trim();

            if (idDriver != 0 && placa != null && (dgvCxT.CurrentRow.Index != -1))
            {

                EN.ConductoresXtaxis a = new EN.ConductoresXtaxis();
                a.id = idDriver;
                a.placaTaxi = placa;
                a.id = Convert.ToInt64(dgvCxT.CurrentRow.Cells["Id"].Value);
                if (conductoresTaxisController.ActualizarCT(a))
                {

                    MessageBox.Show("Se Actualizo El Registro, Ahora el conductor " + Dataconductor[1] + " Conduce el vehiculo " + DataTaxi[0]);
                    llenarDataGridView();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo");
                }

            }
        }

        private void dgvCxT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCxT_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCxT.CurrentRow.Index != -1)
            {
                EN.ConductoresXtaxis other = conductoresTaxisController.MostarCT(Convert.ToInt64(dgvCxT.CurrentRow.Cells["id"].Value));
                EN.Taxis taxi = taxisController.GetTaxi(other.placaTaxi);
                BR.Conductor conductor = conductoresController.MostarConductor(other.conductor);

                cmbTx.Text = (taxi.placa.Trim().ToUpper() + " " +taxi.marca.ToUpper());
                cmbConductor.Text = (conductor.cedula + " " + conductor.nombre.Trim() + " " + conductor.apellido.Trim());
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
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
