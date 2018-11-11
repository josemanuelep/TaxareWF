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
    public partial class AdministrarConductores : Form

    {
        //Instancias para la conexion con la base de datos y los instacias
        db_taxareEntities1 db = new db_taxareEntities1();
       
        Conductor conductor = new Conductor();
        //Controladora para Conductores
        Controladores.ControladorConductores conductoresCon = new Controladores.ControladorConductores();

        public AdministrarConductores()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {

            txtNombre.Text = txtApellido.Text = txtCedula.Text = txtTelefono.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Accion de eliminacion de Conductor", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvConductores.CurrentRow.Index != -1))
            {
                long id = conductoresCon.MostarIdConductor(Convert.ToString(dgvConductores.CurrentRow.Cells["cedula"].Value));
                if (conductoresCon.EliminaConducor(id))
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

                if (conductoresCon.CrearConductor(conductor))
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
            
            
        }

        void llenarDataGridView()
        {

            dgvConductores.AutoGenerateColumns = false;
            dgvConductores.DataSource = conductoresCon.MostrarConductores();


        }

        private void dgvConductores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConductores_DoubleClick(object sender, EventArgs e)
        {
            if (dgvConductores.CurrentRow.Index != -1) {

                int id = Convert.ToInt16(dgvConductores.CurrentRow.Cells["id"].Value);
                conductor = conductoresCon.MostarConductor(id);
                Console.WriteLine(conductor.nombre);
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

            conductor.nombre = txtNombre.Text.Trim();
            conductor.apellido = txtApellido.Text.Trim();
            conductor.cedula = txtCedula.Text.Trim();
            conductor.telefono = txtTelefono.Text.Trim();

                //Conexion con la base de datos

               if (conductoresCon.ActualizarConductor(conductor)&&(conductor.id != 0))
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
    }
      
    }

