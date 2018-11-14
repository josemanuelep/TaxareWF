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



namespace TaxareProject
{
    public partial class AdministrarTaxis : Form
    {
        //Instancia de la clase Taxis
        Taxi tx = new Taxi();
        Controladores.ControladorTaxis Controladora = new Controladores.ControladorTaxis();
        Controladores.ControladorSecretaria Secretarias = new Controladores.ControladorSecretaria();
        Controladores.ControladorMarcas marcas = new Controladores.ControladorMarcas();

        public AdministrarTaxis()
        {
            InitializeComponent();
        }
        public void TaxisJoin()
        {
            using (db_taxareEntities1 db = new db_taxareEntities1()) {

                var query =
                    from tx in db.Taxis
                    join mrk in db.Marcas on tx.id_marca equals mrk.id
                    join sect in db.Secretarias_transito on tx.id_transito equals sect.id
                    //into consulta
                    select new
                    {
                        placa = tx.placa,
                        id_matricula = tx.id_matricula,
                        id_transito = sect.localidad,
                        id_marca = mrk.marca1,
                        modelo = tx.modelo,
                        cilindraje = tx.cilindraje,
                        empresa_alfiliadora = tx.empresa_alfiliadora,
                        Avaluo = tx.avaluo

                    };

                //Poblar DataGridView      
                dgvTaxis.DataSource = query.ToList();
                
            }

            
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
            List<Secretarias_transito> listSecretaria = Secretarias.MostrarSecretarias();

            foreach (Secretarias_transito b in listSecretaria) {

                cmbTransito.Items.Add(b.localidad);
            }
                

        }
        void LlenarMarcas() {

            List<Marca> listMarcas = marcas.MostrarMarcas();

            foreach (Marca b in listMarcas)
            {

                cmbMarcas.Items.Add(b.marca1);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            try
            {

                if ((txtPlaca.Text != null) && EsNumero(txtMatricula.Text) && EsNumero(txtCilindraje.Text) && EsNumero(txtAvaluo.Text)) {

                    tx.placa = txtPlaca.Text.Trim();
                    tx.id_matricula = int.Parse(txtMatricula.Text.Trim());
                    tx.id_transito = Secretarias.MostrarSecretaria(cmbTransito.Text);
                    tx.id_marca = marcas.MostrarMarca(cmbMarcas.Text);
                    tx.modelo = int.Parse(txtModelo.Text.Trim());
                    tx.cilindraje = int.Parse(txtCilindraje.Text.Trim());
                    tx.empresa_alfiliadora = txtEmpresa.Text.Trim();
                    tx.avaluo = int.Parse(txtAvaluo.Text.Trim());

                    //Conexion con la base de datso
                    if (Controladora.CrearTaxi(tx))
                    {
                        llenarDataGridView();
                        MessageBox.Show("Se registro el Taxi con placa " + tx.placa);
                        LimpiarCamposTexto();
                        //Consulta de numero de taxis y taxi con mayor avaluo
                        lblTaxis.Text = Convert.ToString(Controladora.NumeroTaxis());
                        lblAvaluo.Text = Controladora.MaxTax().placa;
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
            TaxisJoin();
           

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
            TaxisJoin();
            //Consulta de numero de taxis y taxi con mayor avaluo
            lblTaxis.Text= Convert.ToString(Controladora.NumeroTaxis());
            lblAvaluo.Text = Controladora.MaxTax().placa;
        }

        private void d(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaxis_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTaxis.CurrentRow.Index != -1) {

                //Datos para consultar datos 
                tx.placa = Convert.ToString(dgvTaxis.CurrentRow.Cells["placa"].Value);
                tx = Controladora.GetTaxi(tx.placa);
                int idtransito = tx.id_transito;
                int idmarca = tx.id_marca;
                //Pintar los datos en los textBoxes
                txtPlaca.Text = tx.placa;
                txtMatricula.Text = Convert.ToString(tx.id_matricula);
                cmbTransito.Text = Secretarias.MostrarSecretaria_String(idtransito);
                cmbMarcas.Text = marcas.MostrarMarca_String(idmarca);
                txtModelo.Text = Convert.ToString(tx.modelo);
                txtCilindraje.Text = Convert.ToString(tx.cilindraje);
                txtEmpresa.Text = Convert.ToString(tx.empresa_alfiliadora);
                txtAvaluo.Text = Convert.ToString(tx.avaluo);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?","Accion de eliminacion de vehiculo",MessageBoxButtons.YesNo)==DialogResult.Yes)&&(dgvTaxis.CurrentRow.Index != -1))
            {
                if (Controladora.EliminarTaxi(txtPlaca.Text))
                {
                    //Console.WriteLine(txtPlaca.Text);
                    MessageBox.Show("Se elimino el registro correctamente");
                    llenarDataGridView();
                    //Consulta de numero de taxis y taxi con mayor avaluo
                    lblTaxis.Text = Convert.ToString(Controladora.NumeroTaxis());
                    lblAvaluo.Text = Controladora.MaxTax().placa;

                }
                else {

                    MessageBox.Show("El registro no se encuentra o debe seleccionar uno");
                }
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            if ((txtPlaca.Text != null) && EsNumero(txtMatricula.Text) && EsNumero(txtCilindraje.Text) && EsNumero(txtAvaluo.Text))
            {
                tx.placa = txtPlaca.Text;
                tx.id_matricula = int.Parse(txtMatricula.Text.Trim());
                tx.id_transito = Secretarias.MostrarSecretaria(cmbTransito.Text);
                tx.id_marca = marcas.MostrarMarca(cmbMarcas.Text);
                tx.modelo = int.Parse(txtModelo.Text.Trim());
                tx.cilindraje = int.Parse(txtCilindraje.Text.Trim());
                tx.empresa_alfiliadora = txtEmpresa.Text.Trim();
                tx.avaluo = int.Parse(txtAvaluo.Text.Trim());

                //Conexion con la base de datos
                if (Controladora.ActualizarTaxi(tx))
                {
                   
                    MessageBox.Show("Se Actualizo el taxi " + tx.placa);
                    llenarDataGridView();
                    LimpiarCamposTexto();
                    //Consulta de numero de taxis y taxi con mayor avaluo
                    lblTaxis.Text = Convert.ToString(Controladora.NumeroTaxis());
                    lblAvaluo.Text = Controladora.MaxTax().placa;
                }
                else {
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

