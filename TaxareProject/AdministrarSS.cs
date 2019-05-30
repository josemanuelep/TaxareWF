using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EN = Entities;
using CT = Controllers;
using BR = Broker;

namespace TaxareProject
{
    public partial class AdministrarSS : Form
    {

        CT.Conductores conductoresController;
        CT.SeguridadSocial seguridadController;

        public AdministrarSS()
        {
            conductoresController = new CT.Conductores();
            seguridadController = new CT.SeguridadSocial();
            InitializeComponent();
            LlenarConductores();
            llenarDataGridView();
            llenarSuma();
            llenarProximosVencer();
            llenarVencidos();
        }
        void llenarVencidos()
        {


            if (seguridadController.Vencidos().Count() > 0)
            {
                cmbVencen.Items.Clear();
                foreach (var item in seguridadController.Vencidos())
                {
                    Console.WriteLine(item.conductor);
                    cmbVencidos.Items.Add(item.id +" "+ item.pago_siguiente);
                }
                cmbVencidos.BackColor = Color.PaleVioletRed;
                cmbVencidos.SelectedIndex = 0;
            }
            else
            {

                cmbVencidos.Text = "No hay ninguna SS vencida";

                cmbVencidos.BackColor = Color.LightBlue;

            }

        }
        void llenarProximosVencer()
        {


            if (seguridadController.VencenDosDias().Count() > 0)
            {

                cmbVencen.DataSource = seguridadController.VencenDosDias();
                cmbVencen.SelectedIndex = 0;
            }
            else
            {

                cmbVencen.Text = "No hay proximos a vencer";

                cmbVencen.BackColor = Color.LightBlue;

            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void LlenarConductores()
        {
            List<BR.Conductor> listConductores = conductoresController.conductoresSinSeguridad();

            cmbConductor.Items.Clear();
            foreach (var b in listConductores)
            {

                cmbConductor.Items.Add(b.cedula + " " + b.nombre.Trim() + " " + b.apellido.Trim());
            }

        }
        void llenarDataGridView()
        {

            dgvSS.AutoGenerateColumns = false;
            dgvSS.DataSource = seguridadController.GetSocials();

        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            //Claves foraneas para id
            String[] Dataconductor = cmbConductor.Text.Split(' ');
            int idDriver = conductoresController.MostarIdConductor(Dataconductor[0].Trim());
            Console.WriteLine(idDriver);

            if (seguridadController.esta(idDriver)!=true)
            {
                if (idDriver.ToString().Length != 0 && txtValor.TextLength != 0)
                {

                    EN.SeguridadSocial a = new EN.SeguridadSocial();
                    a.conductor = Dataconductor[1];
                    a.pago_anterior = dtpInicio.Value.Date;
                    a.pago_siguiente = dtpfinal.Value.Date;
                    a.valor = Convert.ToDouble(txtValor.Text);


                    if (seguridadController.Crear(a, Dataconductor[0]))
                    {

                        MessageBox.Show("Se Añadio El Registro, Ahora el conductor " + Dataconductor[1] + " tiene la SS vigente hasta " + a.pago_siguiente);
                        txtValor.Text = "";
                        llenarSuma();
                        llenarVencidos();
                        llenarProximosVencer();
                        llenarDataGridView();
                    }
                    else
                    {

                        MessageBox.Show("Ocurio un error, intente de nuevo");
                    }
             }
                
            }
            else
            {
                MessageBox.Show("Este conductor ya tiene un SS");
            }


        }

        void llenarSuma()
        {

            //lblsum.Text = seguridadController.SumaTotal().ToString();

        }

        private void dgvSS_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSS.CurrentRow.Index != -1)
            {


                EN.SeguridadSocial other = seguridadController.GetSocial(Convert.ToInt32(dgvSS.CurrentRow.Cells["id"].Value));

                cmbConductor.Text = ( other.conductor);
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
                if (seguridadController.Eliminar(id))
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
            long idDriver = conductoresController.MostarIdConductor(Dataconductor[0].Trim());


            if (idDriver.ToString().Length != 0 && txtValor.TextLength != 0)
            {

                EN.SeguridadSocial a = new EN.SeguridadSocial();
                a.id = Convert.ToInt32(dgvSS.CurrentRow.Cells["id"].Value);
                a.conductor = Dataconductor[1];
                a.pago_anterior = dtpInicio.Value.Date;
                a.pago_siguiente = dtpfinal.Value.Date;
                a.valor = Convert.ToDouble(txtValor.Text);

                if (seguridadController.Actualizar(a,Dataconductor[0]))
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio i = new Inicio();
            i.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

