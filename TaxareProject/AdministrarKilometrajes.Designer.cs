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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvKilometrajes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilometraje1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.cmbTx = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKilometrajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd-MM-yy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(105, 147);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(163, 20);
            this.dtpDate.TabIndex = 43;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpExpedicion_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Fecha";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Placa del Vehiculo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Kilometraje";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvKilometrajes);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnActulizar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.txtKilo);
            this.groupBox1.Controls.Add(this.cmbTx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(747, 345);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Kilometrajes de los Vehiculos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvKilometrajes
            // 
            this.dgvKilometrajes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvKilometrajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKilometrajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.placa,
            this.kilometraje1,
            this.fecha});
            this.dgvKilometrajes.Location = new System.Drawing.Point(283, 31);
            this.dgvKilometrajes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvKilometrajes.Name = "dgvKilometrajes";
            this.dgvKilometrajes.RowTemplate.Height = 24;
            this.dgvKilometrajes.Size = new System.Drawing.Size(443, 304);
            this.dgvKilometrajes.TabIndex = 55;
            this.dgvKilometrajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKilometrajes_CellContentClick);
            this.dgvKilometrajes.DoubleClick += new System.EventHandler(this.dgvKilometrajes_DoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa";
            this.placa.HeaderText = "Vehiculo";
            this.placa.Name = "placa";
            // 
            // kilometraje1
            // 
            this.kilometraje1.DataPropertyName = "kilometraje1";
            this.kilometraje1.HeaderText = "Kilometraje";
            this.kilometraje1.Name = "kilometraje1";
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha de chequeo";
            this.fecha.Name = "fecha";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(18, 236);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(81, 23);
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "Restablecer";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActulizar
            // 
            this.btnActulizar.Location = new System.Drawing.Point(105, 236);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(88, 23);
            this.btnActulizar.TabIndex = 52;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(105, 197);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 23);
            this.btnEliminar.TabIndex = 51;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(16, 197);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(82, 23);
            this.btnCrear.TabIndex = 50;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtKilo
            // 
            this.txtKilo.Location = new System.Drawing.Point(105, 97);
            this.txtKilo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(163, 20);
            this.txtKilo.TabIndex = 48;
            // 
            // cmbTx
            // 
            this.cmbTx.FormattingEnabled = true;
            this.cmbTx.Location = new System.Drawing.Point(105, 49);
            this.cmbTx.Name = "cmbTx";
            this.cmbTx.Size = new System.Drawing.Size(163, 21);
            this.cmbTx.TabIndex = 47;
            // 
            // AdministrarKilometrajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AdministrarKilometrajes";
            this.Text = "AdministrarKilometrajes";
            this.DoubleClick += new System.EventHandler(this.AdministrarKilometrajes_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKilometrajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilometraje1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}