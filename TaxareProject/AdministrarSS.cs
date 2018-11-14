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
    public partial class AdministrarSS : Form
    {
        Controladores.ControladorConductores conductores = new Controladores.ControladorConductores();
        Controladores.ControladoraSS controladora = new Controladores.ControladoraSS();

        public AdministrarSS()
        {
            InitializeComponent();
            LlenarConductores();
            llenarDataGridView();
            llenarSuma();
            llenarProximosVencer();
            llenarVencidos();
        }
        void llenarVencidos() {


            if (controladora.Vencidos().Count() > 0)
            {

                cmbVencidos.DataSource = controladora.Vencidos();
                cmbVencidos.BackColor = Color.PaleVioletRed;
            }
            else
            {

                cmbVencidos.Text = "No hay ninguna SS vencida";

                cmbVencidos.BackColor = Color.LightBlue;

            }

        }
        void llenarProximosVencer() {



            if (controladora.VencenDosDias().Count() > 0)
            {

                cmbVencen.DataSource = controladora.VencenDosDias();
            }
            else {

                cmbVencen.Text = "No hay proximos a vencer";

                cmbVencen.BackColor = Color.LightBlue;

            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        void llenarDataGridView()
        {

            dgvSS.AutoGenerateColumns = false;
            dgvSS.DataSource = controladora.GetSocials();

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Claves foraneas para id
            String[] Dataconductor = cmbConductor.Text.Split(' ');
            long idDriver = conductores.MostarIdConductor(Dataconductor[0].Trim());


            if (idDriver.ToString().Length != 0 && txtValor.TextLength != 0)
            {

                SeguridadSocial a = new SeguridadSocial();
                a.id_conductor = idDriver;
                a.pago_anterior = dtpInicio.Value.Date;
                a.pago_siguiente = dtpfinal.Value.Date;
                a.valor = Convert.ToDouble(txtValor.Text);

                if (controladora.Crear(a))
                {

                    MessageBox.Show("Se Añadio El Registro, Ahora el conductor " + Dataconductor[1] + " tiene la SS vigente hasta " + a.pago_siguiente);
                    llenarDataGridView();
                    txtValor.Text = "";
                    llenarSuma();
                    llenarVencidos();
                    llenarProximosVencer();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo");
                }

            }
        }
        void llenarSuma() {

            lblsum.Text = controladora.SumaTotal().ToString();

        }

        private void dgvSS_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSS.CurrentRow.Index != -1)
            {


                SeguridadSocial other = controladora.GetSocial(Convert.ToInt32(dgvSS.CurrentRow.Cells["id"].Value));
                Conductor b = conductores.MostarConductor(other.id_conductor);

                cmbConductor.Text = (b.cedula + " " + b.nombre.Trim() + " " + b.apellido.Trim());
                dtpfinal.Value = other.pago_siguiente;
                dtpInicio.Value = other.pago_anterior;
                txtValor.Text = other.valor.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvSS.CurrentRow.Index != -1))
            {
                int id = Convert.ToInt32(dgvSS.CurrentRow.Cells["Id"].Value);
                if (controladora.Eliminar(id))
                {
                    MessageBox.Show("Se elimino el registro correctamente");
                    llenarDataGridView();
                    llenarSuma();
                    llenarVencidos();
                    llenarProximosVencer();
                }
                else
                {

                    MessageBox.Show("El registro no se encuentra o debe seleccionar uno");
                }
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            //Claves foraneas para id
            String[] Dataconductor = cmbConductor.Text.Split(' ');
            long idDriver = conductores.MostarIdConductor(Dataconductor[0].Trim());


            if (idDriver.ToString().Length != 0 && txtValor.TextLength != 0)
            {

                SeguridadSocial a = new SeguridadSocial();
                a.id = Convert.ToInt32(dgvSS.CurrentRow.Cells["id"].Value);
                a.id_conductor = idDriver;
                a.pago_anterior = dtpInicio.Value.Date;
                a.pago_siguiente = dtpfinal.Value.Date;
                a.valor = Convert.ToDouble(txtValor.Text);

                if (controladora.Actualizar(a))
                {

                    MessageBox.Show("Se Actualizo el Registro, Ahora el conductor " + Dataconductor[1] + " tiene la SS vigente hasta " + a.pago_siguiente);
                    llenarDataGridView();
                    txtValor.Text = "";
                    llenarSuma();
                    llenarVencidos();
                    llenarProximosVencer();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo");
                }

            }
        }
    }
}
