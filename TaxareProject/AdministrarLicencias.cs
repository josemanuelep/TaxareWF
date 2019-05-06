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

            txtNumero.Text = cmbConductor.Text = cmbTransito.Text = cmbCategoria.Text = "";
            txtNumero.Enabled = true;
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
        void llenarLicVencidas() {

            foreach (var item in licenciasController.licenciasVencidas())
            {
                cmbVencidas.Items.Add("Lic No. "+item.Numero_pase+" de "+ item.conductor);
            }

        }

        void LlenarConductores()
        {
            List<BR.Conductor> listConductores = licenciasController.conductoresSinLicencia();
            if (listConductores.Count()>0)
            {
                foreach (BR.Conductor other in listConductores)
                {

                    cmbConductor.Items.Add(other.cedula.Trim() + " " + other.nombre.Trim() + " " + other.apellido.Trim());
                    
                }
            }
            else
            {
                cmbConductor.Text = "Todos los conductores tienen su licencia";
                cmbConductor.BackColor = Color.OrangeRed;
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
            llenarDataGridView();
            llenarLicVencidas();
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
                    Limpiar();
                    llenarDataGridView();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Accion de eliminacion de Conductor", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvLic.CurrentRow.Index != -1))
            {
                int id = (Convert.ToInt32(dgvLic.CurrentRow.Cells["Numero_pase"].Value));

                if (licenciasController.EliminarLicencia(id))
                {
                    //Console.WriteLine(txtPlaca.Text);
                    MessageBox.Show("Se elimino el registro correctamente");
                    llenarDataGridView();
                    Limpiar();

                }
                else
                {

                    MessageBox.Show("El registro no se encuentra o debe seleccionar uno");
                }
            }
        }
       


        private void dgvLic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLic_DoubleClick(object sender, EventArgs e)
        {
            txtNumero.Enabled = false;
            txtNumero.Text = Convert.ToString(dgvLic.CurrentRow.Cells["Numero_pase"].Value);
            var other = coductoresController.MostarConductorxNombre(Convert.ToString(dgvLic.CurrentRow.Cells["Conductor"].Value));
            cmbConductor.Items.Insert(0,other.cedula.Trim() + " " + other.nombre.Trim() + " " + other.apellido.Trim());
            cmbConductor.SelectedIndex = 0;
            cmbTransito.Items.Insert(0, dgvLic.CurrentRow.Cells["id_secretaria"].Value);
            cmbTransito.SelectedIndex = 0;
            cmbCategoria.Items.Insert(0, dgvLic.CurrentRow.Cells["categoria"].Value);
            cmbCategoria.SelectedIndex = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (radioButtonNombre.Checked)
            {
                var other = licenciasController.MostarLicenciaPorNombre(txtBuscar.Text);

                if (other != null)
                {
                    txtNumero.Text = other.Numero_pase.ToString();
                    cmbConductor.Items.Insert(0, other.cedula+" "+other.conductor.ToUpper());
                    cmbConductor.SelectedIndex = 0;
                    cmbTransito.Items.Insert(0, other.secretaria);
                    cmbTransito.SelectedIndex = 0;
                    cmbCategoria.Items.Insert(0, other.categoria);
                    cmbCategoria.SelectedIndex = 0;
                    dtpExpedicion.Value = other.expedicon;
                    dtpVencimiento.Value = other.vencimiento;
                }else
                    MessageBox.Show("El registro no se encuentra");

            }
            else if (radioButtonpase.Checked) {

                var other = licenciasController.MostarLicencia(Convert.ToInt32(txtBuscar.Text));
                txtNumero.Text = other.Numero_pase.ToString();
                cmbConductor.Items.Insert(0, other.cedula + " " + other.conductor.ToUpper());
                cmbConductor.SelectedIndex = 0;
                cmbTransito.Items.Insert(0, other.secretaria);
                cmbTransito.SelectedIndex = 0;
                cmbCategoria.Items.Insert(0, other.categoria);
                cmbCategoria.SelectedIndex = 0;
                dtpExpedicion.Value = other.expedicon;
                dtpVencimiento.Value = other.vencimiento;
            }
            else
            {
                MessageBox.Show("Seleccione una opcion del radio Boton");
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            if (EsNumero(txtNumero.Text) && (dtpExpedicion.Text != null) && (dtpVencimiento.Text) != null)
            {
                int numeroPase = Convert.ToInt32(dgvLic.CurrentRow.Cells["Numero_pase"].Value);
                //Clave foranea para conductor
                String conductor = cmbConductor.Text;
                String[] Dataconductor = conductor.Split(' ');
                long idDriver = coductoresController.MostarIdConductor(Dataconductor[0]);
                ////Clave foranea para transito
                int idsecretaria = transitoController.MostrarSecretaria(cmbTransito.Text);
                BR.Licencias licencia = new BR.Licencias(Convert.ToInt32(txtNumero.Text.Trim()), idDriver, idsecretaria, cmbCategoria.Text.Trim(), dtpExpedicion.Value.Date, dtpVencimiento.Value.Date);
                licencia.Numero_pase = numeroPase;
                licencia.id_conductor = idDriver;
                licencia.id_secretaria = idsecretaria;
                licencia.categoria = cmbCategoria.Text.Trim();
                licencia.expedicon = dtpExpedicion.Value.Date;
                licencia.vencimiento = dtpVencimiento.Value.Date;

                //Conexion con la base de datos
                if (licenciasController.ActualizarLicencia(licencia))
                {

                    MessageBox.Show("Se Actualizo la licencia" + licencia.Numero_pase);
                    Limpiar();
                    llenarDataGridView();
                }
                else
                {
                    MessageBox.Show("No se pudo Crear");
                }


            }
        }

        private void cmbVencidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
