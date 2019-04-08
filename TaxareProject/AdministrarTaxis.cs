using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EN = Entities;
using CT = Controllers;
using BR = Broker;



namespace TaxareProject
{
    public partial class AdministrarTaxis : Form
    {

        EN.Taxis tx = new EN.Taxis();
        CT.Taxis taxisController = new CT.Taxis();
        CT.Transito transitoController = new CT.Transito();
        CT.Marcas marcasController = new CT.Marcas();
       

        public AdministrarTaxis()
        {
            InitializeComponent();
        }
      


        void LimpiarCamposTexto() {

            txtPlaca.Text=txtModelo.Text= txtCilindraje.Text = txtEmpresa.Text = txtAvaluo.Text = txtMatricula.Text = "";
            
        }
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposTexto();
        }

        void LlenarTransito()
        {
            List<BR.Secretarias_transito> listSecretaria = transitoController.MostrarSecretarias();

            foreach (BR.Secretarias_transito other in listSecretaria)
            {

                cmbTransito.Items.Add(other.localidad);
            }


        }
        void LlenarMarcas() {

            List<BR.Marcas> listMarcas = marcasController.MostrarMarcas();

            foreach (BR.Marcas other in listMarcas)
            {

                cmbMarcas.Items.Add(other.marca);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            EN.Taxis tx = new EN.Taxis();
            try
            {

                if ((txtPlaca.Text != null) && EsNumero(txtMatricula.Text) && EsNumero(txtCilindraje.Text) && EsNumero(txtAvaluo.Text))
                {

                    tx.placa = txtPlaca.Text.Trim();
                    tx.matricula = int.Parse(txtMatricula.Text.Trim());
                    tx.transito =cmbTransito.Text;
                    tx.marca = cmbMarcas.Text;
                    tx.modelo = int.Parse(txtModelo.Text.Trim());
                    tx.cilindraje = int.Parse(txtCilindraje.Text.Trim());
                    tx.empresa_alfiliadora = txtEmpresa.Text.Trim();
                    tx.avaluo = int.Parse(txtAvaluo.Text.Trim());

                    //Conexion con la base de datso
                    if (taxisController.CrearTaxi(tx))
                    {
                        llenarDataGridView();
                        MessageBox.Show("Se registro el Taxi con placa " + tx.placa);
                        LimpiarCamposTexto();
                        //Consulta de numero de taxis y taxi con mayor avaluo
                        lblTaxis.Text = Convert.ToString(taxisController.NumeroTaxis());
                        lblAvaluo.Text = taxisController.MaxTax().placa;
                    }

                }

        }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema inesperado, intente de nuevo");
                throw ex;
            }


}

        void llenarDataGridView() {

            dgvTaxis.AutoGenerateColumns = false;
            dgvTaxis.DataSource = taxisController.MostrarTaxis();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //Metodo a la hora de Cargar el formulario
        private void AdministrarTaxis_Load(object sender, EventArgs e)
        {
            llenarDataGridView();
            LlenarTransito();
            LlenarMarcas();
            //Consulta de numero de taxis y taxi con mayor avaluo
            lblTaxis.Text = Convert.ToString(taxisController.NumeroTaxis());
            lblAvaluo.Text = taxisController.MaxTax().placa;
            var local = taxisController.TaxiMasAntiguo();
            lblAntiguo.Text = local.placa +" "+local.marca;
        }

        private void d(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaxis_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTaxis.CurrentRow.Index != -1) {

                ////Datos para consultar datos 
                string placa = Convert.ToString(dgvTaxis.CurrentRow.Cells["placa"].Value);
                tx = taxisController.GetTaxi(placa);
                //Pintar los datos en los textBoxes
                txtPlaca.Text = tx.placa;
                txtMatricula.Text = Convert.ToString(tx.matricula);
                cmbTransito.Text = tx.transito;
                cmbMarcas.Text = tx.marca;
                txtModelo.Text = Convert.ToString(tx.modelo);
                txtCilindraje.Text = Convert.ToString(tx.cilindraje);
                txtEmpresa.Text = Convert.ToString(tx.empresa_alfiliadora);
                txtAvaluo.Text = Convert.ToString(tx.avaluo);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Accion de eliminacion de vehiculo", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvTaxis.CurrentRow.Index != -1))
            {
                if (taxisController.EliminarTaxi(txtPlaca.Text))
                {
                    //Console.WriteLine(txtPlaca.Text);
                    MessageBox.Show("Se elimino el registro correctamente");
                    llenarDataGridView();
                    //Consulta de numero de taxis y taxi con mayor avaluo
                    lblTaxis.Text = Convert.ToString(taxisController.NumeroTaxis());
                    lblAvaluo.Text = taxisController.MaxTax().placa;

                }
                else
                {

                    MessageBox.Show("El registro no se encuentra o debe seleccionar uno");
                }
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            if ((txtPlaca.Text != null) && EsNumero(txtMatricula.Text) && EsNumero(txtCilindraje.Text) && EsNumero(txtAvaluo.Text))
            {
                tx.placa = txtPlaca.Text;
                tx.matricula = int.Parse(txtMatricula.Text.Trim());
                tx.transito= cmbTransito.Text;
                tx.marca= cmbMarcas.Text;
                tx.modelo = int.Parse(txtModelo.Text.Trim());
                tx.cilindraje = int.Parse(txtCilindraje.Text.Trim());
                tx.empresa_alfiliadora = txtEmpresa.Text.Trim();
                tx.avaluo = int.Parse(txtAvaluo.Text.Trim());

                //Conexion con la base de datos
                if (taxisController.ActualizarTaxi(tx))
                {

                    MessageBox.Show("Se Actualizo el taxi " + tx.placa);
                    llenarDataGridView();
                    LimpiarCamposTexto();
                    //Consulta de numero de taxis y taxi con mayor avaluo
                    lblTaxis.Text = Convert.ToString(taxisController.NumeroTaxis());
                    lblAvaluo.Text = taxisController.MaxTax().placa;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar");
                }

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
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

