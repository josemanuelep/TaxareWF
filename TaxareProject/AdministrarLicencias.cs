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
    public partial class AdministrarLicencias : Form
    {

        //Intancias necesarias
        CT.Conductores coductoresController = new CT.Conductores();
        CT.Transito transitoController = new CT.Transito();
        CT.Licencias licenciasController = new CT.Licencias();
   


        public AdministrarLicencias()
        {
            InitializeComponent();
        }

        //Metodo para verificar si es un numero
        public static Boolean EsNumero(String s)
        {

            try
            {
                long.Parse(s);

            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

        private void Limpiar()
        {

            txtNumero.Text = cmbConductor.Text = cmbTransito.Text = cmbCategoria.Text = " ";

        }

        //Lenar comboBox de transitos
        void LlenarTransito()
        {
            List<BR.Secretarias_transito> listSecretaria = transitoController.MostrarSecretarias();

            foreach (BR.Secretarias_transito other in listSecretaria)
            {

                cmbTransito.Items.Add(other.localidad);
            }

        }

        void LlenarConductores()
        {
            List<BR.Conductor> listConductores = coductoresController.MostrarConductores();


            foreach (BR.Conductor other in listConductores)
            {

                cmbConductor.Items.Add(other.cedula.Trim() + " " + other.nombre.Trim() + " " + other.apellido.Trim());
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

        void llenarDataGridView()
        {

            dgvLic.AutoGenerateColumns = false;
            dgvLic.DataSource = licenciasController.mostrarLicencias();


        }

        private void AdministrarLicencias_Load(object sender, EventArgs e)
        {
            LlenarTransito();
            LlenarConductores();
            llenarCategorias();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (EsNumero(txtNumero.Text) && (dtpExpedicion.Text != null) && (dtpVencimiento.Text) != null)
            {
                
                //Clave foranea para conductor
                String conductor = cmbConductor.Text;
                String[] Dataconductor = conductor.Split(' ');
                long idDriver = coductoresController.MostarIdConductor(Dataconductor[0]);
                ////Clave foranea para transito
                int idsecretaria = transitoController.MostrarSecretaria(cmbTransito.Text);
                BR.Licencias licencia = new BR.Licencias(Convert.ToInt32(txtNumero.Text.Trim()), idDriver, idsecretaria, cmbCategoria.Text.Trim(), dtpExpedicion.Value.Date, dtpVencimiento.Value.Date);
                licencia.Numero_pase = Convert.ToInt32(txtNumero.Text.Trim());
                licencia.id_conductor = idDriver;
                licencia.id_secretaria = idsecretaria;
                licencia.categoria = cmbCategoria.Text.Trim();
                licencia.expedicon = dtpExpedicion.Value.Date;
                licencia.vencimiento = dtpVencimiento.Value.Date;

                //Conexion con la base de datos
                if (licenciasController.CrearLicencia(licencia))
                {

                    MessageBox.Show("Se Añadio la Licencia" + licencia.Numero_pase);
                    llenarDataGridView();
                    Limpiar();

                }
                else
                {
                    MessageBox.Show("No se pudo Crear");
                }


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
