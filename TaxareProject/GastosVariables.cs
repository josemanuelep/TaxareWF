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
            llenarInfo(dateTimePickerDesde.Value);
        }
        private void LlenarTaxis()
        {
            List<EN.Taxis> listConductores = taxisController.MostrarTaxis();

            foreach (EN.Taxis car in listConductores)
            {

                cmbTaxis.Items.Add(car.placa.Trim().ToUpper() + " " + car.marca.ToUpper());
            }

        }

        //Funcion para llenar el DataGridView
        private void LlenarDTG()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = gastosVariablesController.gastosVariables();

        }

        private void llenarInfo(DateTime date) {

            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = gastosVariablesController.GastosporAuto(date);

        }
        private void GastosVariables_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            EN.GastosVariables gastosVariables = new EN.GastosVariables();
            string[] DataTaxi = cmbTaxis.Text.Split(' ');
            string placa = DataTaxi[0].Trim();
            

            if (richTextBox.Text.Length>0 & dtpfecha.Value >= DateTime.Today & txtkilometraje.Text.Length>0 & txtCosto.Text.Length>0)
            {
                gastosVariables.placa = placa;
                gastosVariables.descripcion = richTextBox.Text;
                gastosVariables.fecha = dtpfecha.Value;
                gastosVariables.kilometraje = Convert.ToInt32(txtkilometraje.Text);
                gastosVariables.valor = Convert.ToInt32(txtCosto.Text);

                if (gastosVariablesController.CrearGastoV(gastosVariables))
                {

                    MessageBox.Show("Se Añadio el gasto con un valor de" + gastosVariables.valor);
                    LlenarDTG();
                    llenarInfo(dateTimePickerDesde.Value);
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePickerDesde_ValueChanged(object sender, EventArgs e)
        {
            llenarInfo(dateTimePickerDesde.Value);
        }
    }
}
