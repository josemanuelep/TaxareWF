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
    public partial class AdministrarLicencias : Form
    {

        //Intancias necesarias
        db_taxareEntities1 db = new db_taxareEntities1();
        Licencia licencia = new Licencia();
        Controladores.ControladorConductores conductores = new Controladores.ControladorConductores();
        Controladores.ControladorSecretaria Secretarias = new Controladores.ControladorSecretaria();
        Controladores.ControladoraLicencias licencias = new Controladores.ControladoraLicencias();
   
        public AdministrarLicencias()
        {
            InitializeComponent();
        }

        //Metodo para verificar si es un numero
        public static Boolean EsNumero(String s)
        {

            try
            {
                long.Parse(s);

            }
            catch (Exception)
            {
                return false;
            }
            return true;

        }

        private void Limpiar() {

            txtNumero.Text = cmbConductor.Text = cmbTransito.Text = cmbCategoria.Text = " ";

        }

        //Lenar comboBox de transitos
        void LlenarTransito()
        {
            List<Secretarias_transito> listSecretaria = Secretarias.MostrarSecretarias();

            foreach (Secretarias_transito b in listSecretaria)
            {

                cmbTransito.Items.Add(b.localidad);
            }

        }

        void LlenarConductores()
        {
            List<Conductor> listConductores = conductores.MostrarConductores();


            foreach (Conductor b in listConductores)
            {

                cmbConductor.Items.Add(b.cedula.Trim()+" "+b.nombre.Trim()+" "+b.apellido.Trim());
            }

        }
        void llenarCategorias()
        {
            cmbCategoria.Items.Add("A2");
            cmbCategoria.Items.Add("B1");
            cmbCategoria.Items.Add("B2");
            cmbCategoria.Items.Add("B3");
            cmbCategoria.Items.Add("C1");
            cmbCategoria.Items.Add("C2");
            cmbCategoria.Items.Add("C3");


        }

        public void LicenciasJoin()
        {
            var query =
                from lic in db.Licencias
                join cond in db.Conductors on lic.id_conductor equals cond.id
                join sect in db.Secretarias_transito on lic.id_secretaria equals sect.id

                select new
                {
                    Numero_pase = lic.Numero_pase,
                    Conductor = cond.nombre,
                    id_secretaria = sect.localidad,
                    Categoria = lic.categoria,
                    Expedicion = lic.expedicon,
                    Vencimiento = lic.vencimiento

                };

            //Poblar DataGridView      
            dgvLic.DataSource = query.ToList();


        }

        void llenarDataGridView()
        {

            dgvLic.AutoGenerateColumns = false;
            LicenciasJoin();


        }

        private void AdministrarLicencias_Load(object sender, EventArgs e)
        {
            LlenarTransito();
            LlenarConductores();
            llenarCategorias();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (EsNumero(txtNumero.Text)&&(dtpExpedicion.Text!=null )&&(dtpVencimiento.Text)!=null)
            {
                //Clave foranea para conductor
                String conductor = cmbConductor.Text;
                String[] Dataconductor = conductor.Split(' ');
                long idDriver = conductores.MostarIdConductor(Dataconductor[0]);
                ////Clave foranea para transito
                int idsecretaria = Secretarias.MostrarSecretaria(cmbTransito.Text);

                licencia.Numero_pase = Convert.ToInt32(txtNumero.Text.Trim());
                licencia.id_conductor = idDriver;
                licencia.id_secretaria = idsecretaria;
                licencia.categoria = cmbCategoria.Text.Trim();
                licencia.expedicon = dtpExpedicion.Value.Date;
                licencia.vencimiento = dtpVencimiento.Value.Date;

                //Conexion con la base de datos
                if (licencias.CrearLicencia(licencia))
                {

                    MessageBox.Show("Se Añadio la Licencia" + licencia.Numero_pase);
                    llenarDataGridView();
                    Limpiar();
          
                }
                else
                {
                    MessageBox.Show("No se pudo Crear");
                }


            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
