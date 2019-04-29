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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnConductores_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarConductores ac = new AdministrarConductores();
            ac.Show();

        }

        private void btnLicencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarLicencias al = new AdministrarLicencias();
            al.Show();
        }

        private void btnSS_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarSS ass = new AdministrarSS();
            ass.Show();
        }

        private void btnCxT_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarCxT cxt = new AdministrarCxT();
            cxt.Show();
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btnKiometrajes_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarKilometrajes ak = new AdministrarKilometrajes();
            ak.Show();
        }

        private void btnProducidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarProduccion ap = new AdministrarProduccion();
            ap.Show();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSoats_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrar_Soat ast = new Administrar_Soat();
            ast.Show();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdministrarTaxis at = new AdministrarTaxis();
            at.Show();
        }
    }
}
