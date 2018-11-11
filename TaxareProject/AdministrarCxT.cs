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
    public partial class AdministrarCxT : Form
    {
        Controladores.ControladorConductores conductores = new Controladores.ControladorConductores();
        Controladores.ControladoraConductoresXtaxis controladora = new Controladores.ControladoraConductoresXtaxis();
        Controladores.ControladorTaxis txs = new Controladores.ControladorTaxis();
        Controladores.ControladorMarcas mrks = new Controladores.ControladorMarcas();

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
            dgvCxT.DataSource = controladora.ListaCT();

        }

        void LlenarConductores()
        {
            List<Conductor> listConductores = conductores.MostrarConductores();

            cmbConductor.Items.Clear();
            foreach (Conductor b in listConductores)
            {

                cmbConductor.Items.Add(b.cedula + " " + b.nombre.Trim() + " " + b.apellido.Trim());
            }

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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Claves foraneas para id
            String[] Dataconductor = cmbConductor.Text.Split(' ');
            String[] DataTaxi = cmbTx.Text.Split(' ');

            long idDriver = conductores.MostarIdConductor(Dataconductor[0].Trim());
            String placa = DataTaxi[0].Trim();

            if (idDriver != 0 && placa != null)
            {

                ConductoresXtaxi a = new ConductoresXtaxi();
                a.idConductor = idDriver;
                a.placaTaxi = placa;
                if (controladora.CrearCT(a))
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
                if (controladora.EliminarCT(id))
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

            long idDriver = conductores.MostarIdConductor(Dataconductor[0].Trim());
            String placa = DataTaxi[0].Trim();

            if (idDriver != 0 && placa != null && (dgvCxT.CurrentRow.Index != -1))
            {

                ConductoresXtaxi a = new ConductoresXtaxi();
                a.idConductor = idDriver;
                a.placaTaxi = placa;
                a.id = Convert.ToInt64(dgvCxT.CurrentRow.Cells["Id"].Value);
                if (controladora.ActualizarCT(a))
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
                ConductoresXtaxi other = controladora.MostarCT(Convert.ToInt64(dgvCxT.CurrentRow.Cells["id"].Value));
                Taxi t = txs.GetTaxi(other.placaTaxi);
                Conductor b = conductores.MostarConductor(other.idConductor);

                cmbTx.Text=(t.placa.Trim().ToUpper() + " " + mrks.MostrarMarca_String(t.id_marca).ToUpper());
                cmbConductor.Text=(b.cedula + " " + b.nombre.Trim() + " " + b.apellido.Trim());
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }
    }
}
