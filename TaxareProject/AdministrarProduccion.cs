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
    public partial class AdministrarProduccion : Form
    {
        Controladores.ControladorConductores conductores = new Controladores.ControladorConductores();
        Controladores.ControladorTaxis txs = new Controladores.ControladorTaxis();
        Controladores.ControladorMarcas mrks = new Controladores.ControladorMarcas();
        Controladores.ControladoraProduccion controladora = new Controladores.ControladoraProduccion();

        public AdministrarProduccion()
        {
            InitializeComponent();
            llenarDataGridView();
            LlenarConductores();
            LlenarTaxis();
            txtTotal.ReadOnly = true;
            SwitchDias();

        }

        void llenarDataGridView()
        {

            dgvProducciones.AutoGenerateColumns = false;
            dgvProducciones.DataSource = controladora.ListaPT();

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
        private void SwitchDias()
        {

            lbl.Visible = false;
            lblDias.Visible = false;

        }



        private void AdministrarProduccion_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (cmbConductor.Text.Length != 0 && placa != null && txtLD.Text.Length != 0)
            {

                //Calculo de dias liquidados
                TimeSpan resto = dtpFinal.Value.Date - dtpInicio.Value.Date;
                double total = (resto.TotalDays + 1) * Convert.ToDouble(txtLD.Text.Trim());
                lbl.Visible = true;
                lblDias.Visible = true;
                lblDias.Text = (resto.TotalDays + 1).ToString();
                txtTotal.Text = total.ToString();

            }
            else
            {

                MessageBox.Show("Revise los datos de la liquidacion");
            }
        }
        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            //Claves foraneas
            String[] Dataconductor = cmbConductor.Text.Split(' ');
            String[] DataTaxi = cmbTx.Text.Split(' ');

            if (cmbConductor.Text.Length != 0 && placa != null && txtLD.Text.Length != 0 && txtTotal.Text.Length != 0)
            {

                //Calculo de dias liquidados
                TimeSpan resto = dtpFinal.Value.Date - dtpInicio.Value.Date;
                double total = (resto.TotalDays + 1) * Convert.ToDouble(txtLD.Text.Trim());


                int idDriver = (int)conductores.MostarIdConductor(Dataconductor[0].Trim());
                String placa = DataTaxi[0].Trim();

                //Instancia
                Produccion p = new Produccion();
                p.id_taxista = idDriver;
                p.placa = placa;
                p.inicio = dtpInicio.Value.Date;
                p.final = dtpFinal.Value.Date;
                p.valor = total;
                txtTotal.Text = total.ToString();

                if (controladora.CrearProduccion(p))
                {

                    MessageBox.Show("Se Añadio El Registro, el vehiculo " + DataTaxi[0] + " registra una produccion de " + p.valor + "$ desde " + p.inicio + " hasta " + p.final);
                    llenarDataGridView();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo");
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbConductor.Text = cmbTx.Text = txtLD.Text = txtTotal.Text = " ";
            lbl.Visible = lblDias.Visible = false;
            dtpInicio.Value = DateTime.Today;
            dtpFinal.Value = DateTime.Today;
            llenarDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvProducciones.CurrentRow.Index != -1))
            {
                long id = Convert.ToInt64(dgvProducciones.CurrentRow.Cells["id"].Value);

                if (controladora.EliminarPrduccion(id))
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

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            //Claves foraneas
            String[] Dataconductor = cmbConductor.Text.Split(' ');
            String[] DataTaxi = cmbTx.Text.Split(' ');

            if (cmbConductor.Text.Length != 0 && placa != null && txtLD.Text.Length != 0 && txtTotal.Text.Length != 0)
            {

                //Calculo de dias liquidados
                TimeSpan resto = dtpFinal.Value.Date - dtpInicio.Value.Date;
                double total = (resto.TotalDays + 1) * Convert.ToDouble(txtLD.Text.Trim());


                int idDriver = (int)conductores.MostarIdConductor(Dataconductor[0].Trim());
                String placa = DataTaxi[0].Trim();

                //Instancia
                Produccion p = new Produccion();
                p.id = controladora.id(idDriver);
                p.id_taxista = idDriver;
                p.placa = placa;
                p.inicio = dtpInicio.Value.Date;
                p.final = dtpFinal.Value.Date;
                p.valor = total;
                txtTotal.Text = total.ToString();

                if (controladora.ActualizarProduccion(p))
                {

                    MessageBox.Show("Se Actualizo el Registro");
                    llenarDataGridView();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo");
                }
            }
        }

        private void dgvProducciones_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProducciones.CurrentRow.Index != -1)
            {
                Produccion other = controladora.produccion(Convert.ToInt32(dgvProducciones.CurrentRow.Cells["id"].Value));
                Taxi t = txs.GetTaxi(other.placa);
                Conductor b = conductores.MostarConductor(other.id_taxista);

                //Pintar los datos
                cmbTx.Text = (t.placa.Trim().ToUpper() + " " + mrks.MostrarMarca_String(t.id_marca).ToUpper());
                cmbConductor.Text = (b.cedula + " " + b.nombre.Trim() + " " + b.apellido.Trim());
                dtpInicio.Value = other.inicio;
                dtpFinal.Value = other.final;
                TimeSpan resto = dtpFinal.Value.Date - dtpInicio.Value.Date;
                double pdia = other.valor / (resto.TotalDays + 1);
                txtLD.Text = pdia.ToString();
                txtTotal.Text = other.valor.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void dgvProducciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            if (rdbConductor.Checked && cmbConductor.Text.Length != 0)
            {
                String[] Dataconductor = cmbConductor.Text.Split(' ');
                int idDriver = (int)conductores.MostarIdConductor(Dataconductor[0].Trim());

                List<Querys.ProduccionxTaxis> other = controladora.BuscarProduccionPorConductor(idDriver);
                if (other.Count == 0)
                {
                    MessageBox.Show("No hay registros asociados al conductor de identificacion " + Dataconductor[0]);
                }
                else
                {

                    dgvProducciones.DataSource = other.ToList();
                }


            }

            if (rdbPlaca.Checked && cmbTx.Text.Length != 0)
            {
                String[] DataTaxi = cmbTx.Text.Split(' ');
                String placa = DataTaxi[0].Trim();
                List<Querys.ProduccionxTaxis> other = controladora.BuscarProduccionPorPlaca(placa);
                if (other.Count == 0)
                {
                    MessageBox.Show("No hay registros asociados al vehiculo de placas " + placa);
                }
                else
                {

                    dgvProducciones.DataSource = other.ToList();
                }


            }

            else
            {

                MessageBox.Show("Intente de nuevo");
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
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


