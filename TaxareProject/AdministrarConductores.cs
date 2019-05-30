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

namespace TaxareProject
{
    public partial class AdministrarConductores : Form

    {
    
        EN.Conductor conductor = new EN.Conductor();
        CT.Conductores conductoresController = new CT.Conductores();

        public AdministrarConductores()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {

            txtNombre.Text = txtApellido.Text = txtCedula.Text = txtTelefono.Text = txtBuscar.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Accion de eliminacion de Conductor", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvConductores.CurrentRow.Index != -1))
            {
                long id = conductoresController.MostarIdConductor(Convert.ToString(dgvConductores.CurrentRow.Cells["cedula"].Value));
                if (conductoresController.EliminaConducor(id))
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if ((txtCedula.Text != null) && (txtTelefono.Text != null) && (txtNombre.Text != null) && txtApellido != null)
            {

                conductor.nombre = txtNombre.Text.Trim();
                conductor.apellido = txtApellido.Text.Trim();
                conductor.cedula = txtCedula.Text.Trim();
                conductor.telefono = txtTelefono.Text.Trim();

                if (conductoresController.CrearConductor(conductor))
                {
                    MessageBox.Show("Se registro el Conductor " + conductor.nombre);
                    Limpiar();
                    llenarDataGridView();
                    
                }
                
            }

        }

        //Cuando se carga el formulario
        private void AdministrarConductores_Load(object sender, EventArgs e)
        {
            llenarDataGridView();
            llenarInfo();
            
        }

        private void llenarInfo() {

            var con = conductoresController.ultimorRegistrado();
            lblConductorNombre.Text = con.nombre.ToUpper()+" "+con.apellido.ToUpper();
            lblNumero.Text = conductoresController.Numeroconductores().ToString();

        }

        void llenarDataGridView()
        {

            dgvConductores.AutoGenerateColumns = false;
            dgvConductores.DataSource = conductoresController.MostrarConductores();


        }

        private void dgvConductores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConductores_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConductores.CurrentRow.Index != -1) {

                int id = Convert.ToInt16(dgvConductores.CurrentRow.Cells["id"].Value);
                var conductor = conductoresController.MostarConductor(id);
                txtCedula.Text = conductor.cedula;
                txtNombre.Text = conductor.nombre;
                txtApellido.Text = conductor.apellido;
                txtTelefono.Text = conductor.telefono;


            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            if ((txtCedula.Text != null) && (txtTelefono.Text != null) && (txtNombre.Text != null) && txtApellido != null) {

                EN.Conductor conductorUpdate = new EN.Conductor();
                conductorUpdate.nombre = txtNombre.Text.Trim();
                conductorUpdate.apellido = txtApellido.Text.Trim();
                conductorUpdate.cedula = txtCedula.Text.Trim();
                conductorUpdate.telefono = txtTelefono.Text.Trim();
                conductorUpdate.id = Convert.ToInt64(dgvConductores.CurrentRow.Cells["id"].Value);

                //Conexion con la base de datos

                if (conductoresController.ActualizarConductor(conductorUpdate) &&(conductorUpdate.id != 0))
                {

                    MessageBox.Show("Se Actualizo el conductor " + conductor.nombre);
                    llenarDataGridView();
                    Limpiar();
                    conductor.id = 0;
                }
                
                else
                {
                    MessageBox.Show("No se pudo actualizar");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio i = new Inicio();
            i.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (radioButtonCedula.Checked)
            {
                
                var conductor = conductoresController.MostarConductorxCedula(txtBuscar.Text.Trim());
                if (conductor != null) {

                    txtCedula.Text = conductor.cedula;
                    txtNombre.Text = conductor.nombre;
                    txtApellido.Text = conductor.apellido;
                    txtTelefono.Text = conductor.telefono;
                }
                else {

                    MessageBox.Show("No se encuentra el registro");
                }
                

            }
            else if (radioButtonNombre.Checked)
            {
                var conductor = conductoresController.MostarConductorxNombre(txtBuscar.Text.Trim());
                txtCedula.Text = conductor.cedula;
                txtNombre.Text = conductor.nombre;
                txtApellido.Text = conductor.apellido;
                txtTelefono.Text = conductor.telefono;
            }
            else {

                MessageBox.Show("Elija un parametro para la busqueda");
            }
        }
    }
      

    }

