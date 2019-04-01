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
    public partial class AdministrarGastosVariables : Form

    {
        CT.GastosVariables gastosVariablesController = new CT.GastosVariables();
        CT.Kilometraje kilometrajeController = new CT.Kilometraje();
        CT.Taxis taxisController = new CT.Taxis();


        public AdministrarGastosVariables()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void llenarDataGridView()
        {

            

        }

        void LlenarTaxis()
        {
            

        }

        public void limpiar()
        {

            cmbTx.Text = rtxtDescripcion.Text = txtKilo.Text = txtValor.Text = "";

        }
        private void btnCrear_Click(object sender, EventArgs e)
        {

            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvGastos_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}

