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
    public partial class Administrar_Soat : Form
    {

        Controladores.ControladoraSoat controladora = new Controladores.ControladoraSoat();
        Controladores.ControladorTaxis txs = new Controladores.ControladorTaxis();
        Controladores.ControladorMarcas mrks = new Controladores.ControladorMarcas();
        Soat st = new Soat();

        public Administrar_Soat()
        {
            InitializeComponent();
            llenarDataGridView();
            LlenarTaxis();
        }

        void llenarDataGridView()
        {

            dgvSoat.AutoGenerateColumns = false;
            dgvSoat.DataSource = controladora.GetSoats();

        }
        public void limpiar()
        {

            cmbTx.Text = txtnumero.Text = txtValor.Text = " ";

        }

        void LlenarTaxis()
        {
            List<Taxi> listConductores = txs.MostrarTaxis();

            cmbTx.Items.Clear();
            foreach (Taxi b in listConductores)
            {

                cmbTx.Items.Add(b.placa.Trim().ToUpper() + " " + mrks.MostrarMarca_String(b.id_marca).ToUpper());
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            // Claves foraneas
            String[] DataTaxi = cmbTx.Text.Split(' ');

            if (DataTaxi[0].Trim() != null && txtValor.TextLength != 0 && txtnumero.TextLength != 0)
            {

                String placa = DataTaxi[0].Trim();

                //Instancia
                st.numero = txtnumero.Text.Trim();
                st.placa_taxi = placa;
                st.expedicion = dtpInicio.Value.Date;
                st.expiracion = dtpFinal.Value.Date;
                st.valor = txtValor.Text;

                if (controladora.Crear(st))
                {

                    MessageBox.Show("Se añadio correctamente el registro, ahora el SOAT " + st.numero + " Vence el " + st.expiracion.ToString());
                    llenarDataGridView();
                    limpiar();
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvSoat.CurrentRow.Index != -1))
            {
                int id = Convert.ToInt32(dgvSoat.CurrentRow.Cells["id"].Value);

                if (controladora.Eliminar(id))
                {
                    MessageBox.Show("Se elimino el registro correctamente");
                    llenarDataGridView();
                    limpiar();
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
            // Claves foraneas
            String[] DataTaxi = cmbTx.Text.Split(' ');

            if (DataTaxi[0].Trim() != null && txtValor.TextLength != 0 && txtnumero.TextLength != 0)
            {

                String placa = DataTaxi[0].Trim();

                //Instancia
                st.id = Convert.ToInt32(dgvSoat.CurrentRow.Cells["id"].Value);
                st.numero = txtnumero.Text.Trim();
                st.placa_taxi = placa;
                st.expedicion = dtpInicio.Value.Date;
                st.expiracion = dtpFinal.Value.Date;
                st.valor = txtValor.Text;

                if (controladora.Actualizar(st))
                {

                    MessageBox.Show("Se actualizo correctamente el registro, ahora el SOAT " + st.numero + " Vence el " + st.expiracion.ToString());
                    llenarDataGridView();
                    limpiar();
                }
                else
                {

                    MessageBox.Show("Ocurio un error, intente de nuevo");
                }

            }
        }

        private void dgvSoat_DoubleClick(object sender, EventArgs e)
        {
           

            if (dgvSoat.CurrentRow.Index != -1)
            {
                int id = Convert.ToInt32(dgvSoat.CurrentRow.Cells["id"].Value);
                Soat other = controladora.GetSoat(id);
                Taxi t = txs.GetTaxi(other.placa_taxi);

                //Pintar los datos
                cmbTx.Text = (t.placa.Trim().ToUpper() + " " + mrks.MostrarMarca_String(t.id_marca).ToUpper());
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
    }
}
