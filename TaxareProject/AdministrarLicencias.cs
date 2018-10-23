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
    public partial class AdministrarLicencias : Form
    {

        //Intancias necesarias
        Licencia licencia = new Licencia();
        Controladores.ControladorConductores conductores = new Controladores.ControladorConductores();
        Controladores.ControladorSecretaria Secretarias = new Controladores.ControladorSecretaria();
        Controladores.ControladorMarcas marcas = new Controladores.ControladorMarcas();
        public AdministrarLicencias()
        {
            InitializeComponent();
        }

        //Lenar comboBox de transitos
        void LlenarTransito()
        {
            List<Secretarias_transito> listSecretaria = Secretarias.MostrarSecretarias();

            foreach (Secretarias_transito b in listSecretaria)
            {

                cmbTransito.Items.Add(b.localidad);
            }

        }

        void LlenarConductores()
        {
            List<Conductor> listConductores = conductores.MostrarConductores();


            foreach (Conductor b in listConductores)
            {

                cmbConductor.Items.Add(b.nombre + b.apellido + "-" + b.cedula);
            }

        }
        void llenarCategorias()
        {
            cmbCategoria.Items.Add("A2");
            cmbCategoria.Items.Add("B1");
            cmbCategoria.Items.Add("B2");
            cmbCategoria.Items.Add("B3");
            cmbCategoria.Items.Add("C1");
            cmbCategoria.Items.Add("C2");
            cmbCategoria.Items.Add("C3");


        }

        private void AdministrarLicencias_Load(object sender, EventArgs e)
        {
            LlenarTransito();
            LlenarConductores();
            llenarCategorias();
        }
    }
}
