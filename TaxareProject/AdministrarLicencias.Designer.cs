namespace TaxareProject
{
    partial class AdministrarLicencias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbConductor = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpExpedicion = new System.Windows.Forms.DateTimePicker();
            this.cmbTransito = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVencidas = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.radioButtonpase = new System.Windows.Forms.RadioButton();
            this.radioButtonNombre = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvLic = new System.Windows.Forms.DataGridView();
            this.Numero_pase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_secretaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expedicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dgvLic);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1124, 512);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administar Licencias";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TaxareProject.Properties.Resources.Logo;
            this.pictureBox1.Image = global::TaxareProject.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(132, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbConductor);
            this.groupBox5.Controls.Add(this.txtNumero);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.dtpVencimiento);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.dtpExpedicion);
            this.groupBox5.Controls.Add(this.cmbTransito);
            this.groupBox5.Controls.Add(this.cmbCategoria);
            this.groupBox5.Location = new System.Drawing.Point(13, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(380, 162);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Crear";
            // 
            // cmbConductor
            // 
            this.cmbConductor.FormattingEnabled = true;
            this.cmbConductor.Location = new System.Drawing.Point(139, 58);
            this.cmbConductor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbConductor.Name = "cmbConductor";
            this.cmbConductor.Size = new System.Drawing.Size(224, 24);
            this.cmbConductor.TabIndex = 38;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(139, 27);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(224, 22);
            this.txtNumero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número de pase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tránsito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(190, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expedición";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conductor";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "dd-MM-yy";
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(283, 90);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(80, 22);
            this.dtpVencimiento.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vencimiento";
            // 
            // dtpExpedicion
            // 
            this.dtpExpedicion.CustomFormat = "dd-MM-yy";
            this.dtpExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpedicion.Location = new System.Drawing.Point(283, 120);
            this.dtpExpedicion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpedicion.Name = "dtpExpedicion";
            this.dtpExpedicion.Size = new System.Drawing.Size(80, 22);
            this.dtpExpedicion.TabIndex = 41;
            // 
            // cmbTransito
            // 
            this.cmbTransito.FormattingEnabled = true;
            this.cmbTransito.Location = new System.Drawing.Point(84, 92);
            this.cmbTransito.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTransito.Name = "cmbTransito";
            this.cmbTransito.Size = new System.Drawing.Size(98, 24);
            this.cmbTransito.TabIndex = 39;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(84, 127);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(98, 24);
            this.cmbCategoria.TabIndex = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cmbVencidas);
            this.groupBox4.Location = new System.Drawing.Point(13, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 83);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Licencias Vencidas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 12);
            this.label7.TabIndex = 54;
            this.label7.Text = "Recuerde que un conductor sin licencia representa una violacion de una norma de t" +
    "ransito";
            // 
            // cmbVencidas
            // 
            this.cmbVencidas.FormattingEnabled = true;
            this.cmbVencidas.Location = new System.Drawing.Point(7, 22);
            this.cmbVencidas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVencidas.Name = "cmbVencidas";
            this.cmbVencidas.Size = new System.Drawing.Size(344, 24);
            this.cmbVencidas.TabIndex = 53;
            this.cmbVencidas.SelectedIndexChanged += new System.EventHandler(this.cmbVencidas_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.radioButtonpase);
            this.groupBox3.Controls.Add(this.radioButtonNombre);
            this.groupBox3.Controls.Add(this.txtBuscar);
            this.groupBox3.Location = new System.Drawing.Point(13, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 80);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(250, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(101, 28);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // radioButtonpase
            // 
            this.radioButtonpase.AutoSize = true;
            this.radioButtonpase.Location = new System.Drawing.Point(141, 21);
            this.radioButtonpase.Name = "radioButtonpase";
            this.radioButtonpase.Size = new System.Drawing.Size(86, 21);
            this.radioButtonpase.TabIndex = 6;
            this.radioButtonpase.TabStop = true;
            this.radioButtonpase.Text = "Por pase";
            this.radioButtonpase.UseVisualStyleBackColor = true;
            // 
            // radioButtonNombre
            // 
            this.radioButtonNombre.AutoSize = true;
            this.radioButtonNombre.Location = new System.Drawing.Point(7, 21);
            this.radioButtonNombre.Name = "radioButtonNombre";
            this.radioButtonNombre.Size = new System.Drawing.Size(103, 21);
            this.radioButtonNombre.TabIndex = 5;
            this.radioButtonNombre.TabStop = true;
            this.radioButtonNombre.Text = "Por nombre";
            this.radioButtonNombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(6, 48);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(220, 22);
            this.txtBuscar.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCrear);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnActulizar);
            this.groupBox2.Location = new System.Drawing.Point(13, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 59);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(7, 22);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(84, 28);
            this.btnCrear.TabIndex = 45;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(99, 22);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(72, 28);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(274, 20);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(77, 28);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Location = new System.Drawing.Point(182, 21);
            this.btnActulizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(84, 28);
            this.btnActulizar.TabIndex = 47;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1008, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 49;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvLic
            // 
            this.dgvLic.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLic.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_pase,
            this.conductor,
            this.id_secretaria,
            this.categoria,
            this.expedicion,
            this.vencimiento});
            this.dgvLic.Location = new System.Drawing.Point(400, 46);
            this.dgvLic.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLic.Name = "dgvLic";
            this.dgvLic.Size = new System.Drawing.Size(700, 459);
            this.dgvLic.TabIndex = 43;
            this.dgvLic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLic_CellContentClick);
            this.dgvLic.DoubleClick += new System.EventHandler(this.dgvLic_DoubleClick);
            // 
            // Numero_pase
            // 
            this.Numero_pase.DataPropertyName = "Numero_pase";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Numero_pase.DefaultCellStyle = dataGridViewCellStyle1;
            this.Numero_pase.HeaderText = "Pase No.";
            this.Numero_pase.Name = "Numero_pase";
            // 
            // conductor
            // 
            this.conductor.DataPropertyName = "Conductor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.conductor.DefaultCellStyle = dataGridViewCellStyle2;
            this.conductor.HeaderText = "Conductor";
            this.conductor.Name = "conductor";
            // 
            // id_secretaria
            // 
            this.id_secretaria.DataPropertyName = "secretaria";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_secretaria.DefaultCellStyle = dataGridViewCellStyle3;
            this.id_secretaria.HeaderText = "Secretaria";
            this.id_secretaria.Name = "id_secretaria";
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.categoria.DefaultCellStyle = dataGridViewCellStyle4;
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // expedicion
            // 
            this.expedicion.DataPropertyName = "expedicon";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.expedicion.DefaultCellStyle = dataGridViewCellStyle5;
            this.expedicion.HeaderText = "Expedicion";
            this.expedicion.Name = "expedicion";
            // 
            // vencimiento
            // 
            this.vencimiento.DataPropertyName = "vencimiento";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vencimiento.DefaultCellStyle = dataGridViewCellStyle6;
            this.vencimiento.HeaderText = "Caducidad";
            this.vencimiento.Name = "vencimiento";
            // 
            // AdministrarLicencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 538);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministrarLicencias";
            this.Text = "AdministrarLicencias";
            this.Load += new System.EventHandler(this.AdministrarLicencias_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.DateTimePicker dtpExpedicion;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbTransito;
        private System.Windows.Forms.ComboBox cmbConductor;
        private System.Windows.Forms.DataGridView dgvLic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonpase;
        private System.Windows.Forms.RadioButton radioButtonNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbVencidas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_pase;
        private System.Windows.Forms.DataGridViewTextBoxColumn conductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_secretaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn expedicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimiento;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}