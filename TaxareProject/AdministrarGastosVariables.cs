﻿using System;
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
            taxisController = new CT.Taxis();
            marcasController = new CT.Marcas();
            turnosController = new CT.Turnos();
            gastosVariablesController = new CT.GastosVariables();
            LlenarDTG();
            LlenarTaxis();
        }

        //Funcion para llenar el DataGridView
        private void LlenarDTG() {

            dgvGastos.AutoGenerateColumns = false;
            dgvGastos.DataSource = gastosVariablesController.gastosVariables();
        }

        private void LlenarTaxis()
        {
            List<EN.Taxis> listConductores = taxisController.MostrarTaxis();

            cmbTx.Items.Clear();

            foreach (EN.Taxis car in listConductores)
            {

                cmbTx.Items.Add(car.placa.Trim().ToUpper() + " " + car.marca.ToUpper());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            String[] DataTaxi = cmbTx.Text.Split(' ');
            string descripcion = txtDescripcion.Text;
            System.DateTime fecha = dtpDate.Value;

            //Verificar que sean campos numericos
            int kilometraje ;
            int valor;
            bool puedeConvertirtKilometraje = int.TryParse(txtKilo.Text , out kilometraje);
            bool puedeConvertirValor = int.TryParse(txtValor.Text , out valor);

            if (descripcion != "" && puedeConvertirtKilometraje && puedeConvertirtKilometraje)
            {
                EN.GastosVariables gastosVariables = new EN.GastosVariables();
                gastosVariables.descripcion = descripcion;
                gastosVariables.fecha = fecha;
                gastosVariables.kilometraje = kilometraje;
                gastosVariables.placa = DataTaxi[0].Trim();
                gastosVariables.valor = valor;

                if (gastosVariablesController.CrearGastoV(gastosVariables))
                {
                    MessageBox.Show("Se Añadio El Registro, Ahora el gasto " + gastosVariables.descripcion + " queda asocidado a " + DataTaxi[0]);
                    LlenarDTG();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el registro, intente de nuevo");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDescripcion.Text = txtBuscar.Text = txtKilo.Text = txtValor.Text = " ";
        }

        private void dgvGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGastos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvGastos.CurrentRow.Index != -1)
            {
                BR.GastosVariables other = gastosVariablesController.DevuelveGV(Convert.ToInt32(dgvGastos.CurrentRow.Cells["id"].Value));
                EN.Taxis taxi = taxisController.GetTaxi(other.placa);
                cmbTx.Text = (taxi.placa.Trim().ToUpper() + " " + taxi.marca.ToUpper());
                txtValor.Text = other.valor.ToString();
                txtKilo.Text = other.kilometraje.ToString();
                txtDescripcion.Text = other.descripcion;
            }
            else
            {
                MessageBox.Show("Seleccione un registro");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("¿Esta seguro que desea eliminar el registro selccionado?", "Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes) && (dgvGastos.CurrentRow.Index != -1))
            {
                long id = Convert.ToInt64(dgvGastos.CurrentRow.Cells["Id"].Value);

                if (gastosVariablesController.EliminarGastoV(Convert.ToInt32(id)))
                {
                    MessageBox.Show("Se elimino el registro correctamente");
                    LlenarDTG();
                }
                else
                {

                    MessageBox.Show("El registro no se encuentra o debe seleccionar uno");
                }
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            String[] DataTaxi = cmbTx.Text.Split(' ');
            string descripcion = txtDescripcion.Text;
            System.DateTime fecha = dtpDate.Value;

            //Verificar que sean campos numericos
            int kilometraje;
            int valor;
            bool puedeConvertirtKilometraje = int.TryParse(txtKilo.Text, out kilometraje);
            bool puedeConvertirValor = int.TryParse(txtValor.Text, out valor);

            if (descripcion != "" && puedeConvertirtKilometraje && puedeConvertirtKilometraje)
            {
                EN.GastosVariables gastosVariables = new EN.GastosVariables();
                gastosVariables.id = Convert.ToInt32(dgvGastos.CurrentRow.Cells["Id"].Value);
                gastosVariables.descripcion = descripcion;
                gastosVariables.fecha = fecha;
                gastosVariables.kilometraje = kilometraje;
                gastosVariables.placa = DataTaxi[0].Trim();
                gastosVariables.valor = valor;

                if (gastosVariablesController.ActualizarGastosV(gastosVariables))
                {
                    MessageBox.Show("Se actualizo el registro");
                    LlenarDTG();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro, intente de nuevo");
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
