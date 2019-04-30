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

        CT.Taxis taxisController;
        CT.Marcas marcasController;
        CT.Turnos turnosController;
        CT.GastosVariables gastosVariablesController;

        public AdministrarGastosVariables()
        {
            InitializeComponent();
            InitializeComponent();
            taxisController = new CT.Taxis();
            marcasController = new CT.Marcas();
            turnosController = new CT.Turnos();
            gastosVariablesController = new CT.GastosVariables();
           
        }

        private void LlenarTaxis()
        {
            List<EN.Taxis> listConductores = taxisController.MostrarTaxis();

            foreach (EN.Taxis car in listConductores)
            {

                cmb.Items.Add(car.placa.Trim().ToUpper() + " " + car.marca.ToUpper());
            }

        }

        //Funcion para llenar el DataGridView
        private void LlenarDTG()
        { 
            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = gastosVariablesController.gastosVariables();

        }

        private void AdministrarGastosVariables_Load(object sender, EventArgs e)
        {
            LlenarDTG();
            LlenarTaxis();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
    }
}
