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

        private void AdministrarProduccion_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Claves foraneas
            String[] Dataconductor = cmbConductor.Text.Split(' ');
            String[] DataTaxi = cmbTx.Text.Split(' ');

            int idDriver = (int)conductores.MostarIdConductor(Dataconductor[0].Trim());
            String placa = DataTaxi[0].Trim();
            Produccion p = new Produccion();
            //Instancia
            p.id_taxista = idDriver;
            p.placa = placa;
            p.inicio = dtpInicio.Value.Date;
            p.final = dtpFinal.Value.Date;
            p.valor = Convert.ToDouble(txtTotal.Text.Trim());

            if (idDriver != 0 && placa != null && txtTotal.Text.Length!=0)
            {

               
                
                if (controladora.CrearProduccion(p))
                {

                    MessageBox.Show("Se Añadio El Registro, el vehiculo " + DataTaxi[0] +" registra una produccion de "+ p.valor+"$ desde "+p.inicio+" hasta "+p.final);
                    llenarDataGridView();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo");
                }

            }
        }
    }
}
