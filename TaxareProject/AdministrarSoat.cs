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

namespace TaxareProject
{
    public partial class Administrar_Soat : Form
    {

        CT.Soat soatController;
        CT.Taxis taxisController;
        CT.Marcas marcasController;

        public Administrar_Soat()
        {
            soatController = new CT.Soat();
            taxisController = new CT.Taxis();
            marcasController = new CT.Marcas();
            InitializeComponent();
            llenarDataGridView();
            LlenarTaxis();
            llenarProximosAvencer();
            llenarVencidos();
        }

        void llenarDataGridView()
        {

            dgvSoat.AutoGenerateColumns = false;
            dgvSoat.DataSource = soatController.GetSoats();

        }
        public void limpiar()
        {

            cmbTx.Text = txtnumero.Text = txtValor.Text = " ";

        }

        void LlenarTaxis()
        {
            
            cmbTx.Items.Clear();
            foreach (EN.Taxis b in taxisController.MostrarTaxis())
            {

                cmbTx.Items.Add(b.placa.Trim().ToUpper() + " " + b.marca.ToUpper());
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void llenarProximosAvencer()
        {

            if (soatController.ProximosVencer().Count == 0)
            {
                cmbProximos.Items.Add("No hay licencias proximas a vencer");
                cmbProximos.SelectedIndex = 0;
            }
            else
            {

                foreach (var item in soatController.ProximosVencer())
                {
                    cmbProximos.Items.Add(item.numero + " del vehiculo " + item.placa_taxi.ToUpper());
                }
                cmbProximos.SelectedIndex = 0;
                cmbProximos.BackColor = Color.LightYellow;
                lblnumero.Text = soatController.GetSoats().Count.ToString();
            }


        }

        public void llenarVencidos()
        {
            if (soatController.obtenerVencidos().Count == 0 )
            {
                cmbVencidos.Items.Add("No hay licencias vencidas");
            }
            else
            {
                foreach (var item in soatController.obtenerVencidos())
                {
                    cmbVencidos.Items.Add(item.numero + " del vehiculo " + item.placa_taxi.ToUpper());
                }
                cmbVencidos.SelectedIndex = 0;
                cmbVencidos.BackColor = Color.OrangeRed;
            }

           

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            // Claves foraneas
            String[] DataTaxi = cmbTx.Text.Split(' ');

            if (DataTaxi[0].Trim() != null && txtValor.TextLength != 0 && txtnumero.TextLength != 0)
            {

                String placa = DataTaxi[0].Trim();
                EN.Soat soat = new EN.Soat();
                //Instancia
                soat.numero = txtnumero.Text.Trim();
                soat.placa_taxi = placa;
                soat.expedicion = dtpInicio.Value.Date;
                soat.expiracion = dtpFinal.Value.Date;
                soat.valor = txtValor.Text;

                if (soatController.Crear(soat))
                {

                    MessageBox.Show("Se añadio correctamente el registro, ahora el SOAT " + soat.numero + " Vence el " + soat.expiracion.ToString());
                    llenarDataGridView();
                    limpiar();
                    llenarProximosAvencer();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo");
                }

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            llenarDataGridView();
            limpiar();
            llenarProximosAvencer();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvSoat.CurrentRow.Index != -1))
            {
                string numero = dgvSoat.CurrentRow.Cells["numero"].Value.ToString();
                var other = soatController.GetSoatPorNumero(numero);

                if (soatController.Eliminar(other.id))
                {
                    MessageBox.Show("Se elimino el registro correctamente");
                    llenarDataGridView();
                    limpiar();
                    llenarProximosAvencer();
                }
                else
                {

                    MessageBox.Show("El registro no se encuentra o debe seleccionar uno");
                }
            }
        }

        private void Administrar_Soat_Load(object sender, EventArgs e)
        {

        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            //// Claves foraneas
            //String[] DataTaxi = cmbTx.Text.Split(' ');

            //if (DataTaxi[0].Trim() != null && txtValor.TextLength != 0 && txtnumero.TextLength != 0)
            //{

            //    String placa = DataTaxi[0].Trim();

            //    //Instancia
            //    st.id = Convert.ToInt32(dgvSoat.CurrentRow.Cells["id"].Value);
            //    st.numero = txtnumero.Text.Trim();
            //    st.placa_taxi = placa;
            //    st.expedicion = dtpInicio.Value.Date;
            //    st.expiracion = dtpFinal.Value.Date;
            //    st.valor = txtValor.Text;

            //    if (controladora.Actualizar(st))
            //    {

            //        MessageBox.Show("Se actualizo correctamente el registro, ahora el SOAT " + st.numero + " Vence el " + st.expiracion.ToString());
            //        llenarDataGridView();
            //        limpiar();
            //        llenarProximosAvencer();
            //    }
            //    else
            //    {

            //        MessageBox.Show("Ocurio un error, intente de nuevo");
            //    }

            //}
        }

        private void dgvSoat_DoubleClick(object sender, EventArgs e)
        {


            if (dgvSoat.CurrentRow.Index != -1)
            {
                string id = dgvSoat.CurrentRow.Cells["numero"].Value.ToString();
                var other = soatController.GetSoatPorNumero(id);
                var taxi = taxisController.GetTaxi(other.placa_taxi);

                //Pintar los datos
                cmbTx.Text = (taxi.placa.Trim().ToUpper() + " " + taxi.marca.ToUpper());
                dtpInicio.Value = other.expedicion;
                dtpFinal.Value = other.expiracion;
                txtnumero.Text = other.numero;
                txtValor.Text = other.valor;

            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio i = new Inicio();
            i.Show();
        }

        private void dgvSoat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbTx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Crear_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

