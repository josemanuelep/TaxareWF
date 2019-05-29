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
    public partial class GastosVariables : Form
    {

        CT.Taxis taxisController;
        CT.Marcas marcasController;
        CT.Turnos turnosController;
        CT.GastosVariables gastosVariablesController;

        public GastosVariables()
        {
            InitializeComponent();
            taxisController = new CT.Taxis();
            marcasController = new CT.Marcas();
            turnosController = new CT.Turnos();
            gastosVariablesController = new CT.GastosVariables();
            LlenarTaxis();
            LlenarDTG();
        }
        private void LlenarTaxis()
        {
            List<EN.Taxis> listConductores = taxisController.MostrarTaxis();

            foreach (EN.Taxis car in listConductores)
            {

                comboBox1.Items.Add(car.placa.Trim().ToUpper() + " " + car.marca.ToUpper());
            }

        }

        //Funcion para llenar el DataGridView
        private void LlenarDTG()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = gastosVariablesController.gastosVariables();

        }
        private void GastosVariables_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
