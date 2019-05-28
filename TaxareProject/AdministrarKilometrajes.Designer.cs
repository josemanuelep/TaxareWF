namespace TaxareProject
{
    partial class AdministrarKilometrajes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMinMarca = new System.Windows.Forms.Label();
            this.lblMinPlaca = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaxMarca = new System.Windows.Forms.Label();
            this.lblMaxPlaca = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Acciones = new System.Windows.Forms.GroupBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvKilometrajes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometraje1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.cmbTx = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.Acciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKilometrajes)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(303, 53);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(75, 22);
            this.dtpDate.TabIndex = 43;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpExpedicion_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fecha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 44;
            this.label1.Text = "Placa del Vehiculo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Kilometraje";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Acciones);
            this.groupBox1.Controls.Add(this.dgvKilometrajes);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(15, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1057, 513);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Kilometrajes de los Vehiculos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(11, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 217);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info.";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.lblMinMarca);
            this.groupBox4.Controls.Add(this.lblMinPlaca);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(16, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 92);
            this.groupBox4.TabIndex = 79;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Automovil con menos recorrido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 70;
            this.label3.Text = "Placa";
            // 
            // lblMinMarca
            // 
            this.lblMinMarca.AutoSize = true;
            this.lblMinMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMinMarca.Location = new System.Drawing.Point(128, 66);
            this.lblMinMarca.Name = "lblMinMarca";
            this.lblMinMarca.Size = new System.Drawing.Size(41, 17);
            this.lblMinMarca.TabIndex = 77;
            this.lblMinMarca.Text = "Taxis";
            // 
            // lblMinPlaca
            // 
            this.lblMinPlaca.AutoSize = true;
            this.lblMinPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMinPlaca.Location = new System.Drawing.Point(128, 30);
            this.lblMinPlaca.Name = "lblMinPlaca";
            this.lblMinPlaca.Size = new System.Drawing.Size(41, 17);
            this.lblMinPlaca.TabIndex = 72;
            this.lblMinPlaca.Text = "Taxis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 17);
            this.label9.TabIndex = 76;
            this.label9.Text = "Marca";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblMaxMarca);
            this.groupBox3.Controls.Add(this.lblMaxPlaca);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(16, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 83);
            this.groupBox3.TabIndex = 78;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automovil con mas recorrido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Placa";
            // 
            // lblMaxMarca
            // 
            this.lblMaxMarca.AutoSize = true;
            this.lblMaxMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblMaxMarca.Location = new System.Drawing.Point(128, 58);
            this.lblMaxMarca.Name = "lblMaxMarca";
            this.lblMaxMarca.Size = new System.Drawing.Size(41, 17);
            this.lblMaxMarca.TabIndex = 77;
            this.lblMaxMarca.Text = "Taxis";
            // 
            // lblMaxPlaca
            // 
            this.lblMaxPlaca.AutoSize = true;
            this.lblMaxPlaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblMaxPlaca.Location = new System.Drawing.Point(128, 28);
            this.lblMaxPlaca.Name = "lblMaxPlaca";
            this.lblMaxPlaca.Size = new System.Drawing.Size(41, 17);
            this.lblMaxPlaca.TabIndex = 72;
            this.lblMaxPlaca.Text = "Taxis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 76;
            this.label8.Text = "Marca";
            // 
            // Acciones
            // 
            this.Acciones.Controls.Add(this.btnCrear);
            this.Acciones.Controls.Add(this.btnLimpiar);
            this.Acciones.Controls.Add(this.btnActulizar);
            this.Acciones.Controls.Add(this.btnEliminar);
            this.Acciones.Location = new System.Drawing.Point(11, 210);
            this.Acciones.Name = "Acciones";
            this.Acciones.Size = new System.Drawing.Size(386, 67);
            this.Acciones.TabIndex = 56;
            this.Acciones.TabStop = false;
            this.Acciones.Text = "Acciones";
            this.Acciones.Enter += new System.EventHandler(this.Acciones_Enter);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(7, 22);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(86, 28);
            this.btnCrear.TabIndex = 50;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(282, 22);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 28);
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "Restablecer";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Location = new System.Drawing.Point(193, 22);
            this.btnActulizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(86, 28);
            this.btnActulizar.TabIndex = 52;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(99, 22);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 28);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvKilometrajes
            // 
            this.dgvKilometrajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKilometrajes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKilometrajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvKilometrajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKilometrajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.placa,
            this.kilometraje1,
            this.fecha});
            this.dgvKilometrajes.Location = new System.Drawing.Point(416, 60);
            this.dgvKilometrajes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKilometrajes.Name = "dgvKilometrajes";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKilometrajes.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvKilometrajes.RowTemplate.Height = 24;
            this.dgvKilometrajes.Size = new System.Drawing.Size(623, 440);
            this.dgvKilometrajes.TabIndex = 55;
            this.dgvKilometrajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKilometrajes_CellContentClick);
            this.dgvKilometrajes.DoubleClick += new System.EventHandler(this.dgvKilometrajes_DoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 48;
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.placa.DefaultCellStyle = dataGridViewCellStyle2;
            this.placa.HeaderText = "Vehiculo";
            this.placa.Name = "placa";
            // 
            // kilometraje1
            // 
            this.kilometraje1.DataPropertyName = "kilometraje";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.kilometraje1.DefaultCellStyle = dataGridViewCellStyle3;
            this.kilometraje1.HeaderText = "Kilometraje";
            this.kilometraje1.Name = "kilometraje1";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.fecha.HeaderText = "Fecha de chequeo";
            this.fecha.Name = "fecha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(955, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 54;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(136, 52);
            this.txtKilo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(116, 22);
            this.txtKilo.TabIndex = 48;
            // 
            // cmbTx
            // 
            this.cmbTx.FormattingEnabled = true;
            this.cmbTx.Location = new System.Drawing.Point(139, 19);
            this.cmbTx.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTx.Name = "cmbTx";
            this.cmbTx.Size = new System.Drawing.Size(223, 24);
            this.cmbTx.TabIndex = 47;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.cmbTx);
            this.groupBox5.Controls.Add(this.dtpDate);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtKilo);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(11, 120);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(386, 84);
            this.groupBox5.TabIndex = 58;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Crear";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TaxareProject.Properties.Resources.Logo;
            this.pictureBox1.Image = global::TaxareProject.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(124, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // AdministrarKilometrajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 538);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdministrarKilometrajes";
            this.Text = "AdministrarKilometrajes";
            this.Load += new System.EventHandler(this.AdministrarKilometrajes_Load);
            this.DoubleClick += new System.EventHandler(this.AdministrarKilometrajes_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.Acciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKilometrajes)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.ComboBox cmbTx;
        private System.Windows.Forms.DataGridView dgvKilometrajes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox Acciones;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaxPlaca;
        private System.Windows.Forms.Label lblMaxMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMinMarca;
        private System.Windows.Forms.Label lblMinPlaca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometraje1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}