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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvLic = new System.Windows.Forms.DataGridView();
            this.Numero_pase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_conductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_secretaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expedicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpExpedicion = new System.Windows.Forms.DateTimePicker();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbTransito = new System.Windows.Forms.ComboBox();
            this.cmbConductor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnActulizar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.dgvLic);
            this.groupBox1.Controls.Add(this.dtpVencimiento);
            this.groupBox1.Controls.Add(this.dtpExpedicion);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.cmbTransito);
            this.groupBox1.Controls.Add(this.cmbConductor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1308, 524);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administar Licencias";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 49;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(329, 405);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(84, 28);
            this.btnLimpiar.TabIndex = 48;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnActulizar
            // 
            this.btnActulizar.Location = new System.Drawing.Point(219, 405);
            this.btnActulizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(100, 28);
            this.btnActulizar.TabIndex = 47;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(119, 405);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 28);
            this.btnEliminar.TabIndex = 46;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(25, 405);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(85, 28);
            this.btnCrear.TabIndex = 45;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvLic
            // 
            this.dgvLic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero_pase,
            this.id_conductor,
            this.id_secretaria,
            this.categoria,
            this.expedicion,
            this.vencimiento});
            this.dgvLic.Location = new System.Drawing.Point(433, 62);
            this.dgvLic.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLic.Name = "dgvLic";
            this.dgvLic.Size = new System.Drawing.Size(867, 436);
            this.dgvLic.TabIndex = 43;
            // 
            // Numero_pase
            // 
            this.Numero_pase.DataPropertyName = "Numero_pase";
            this.Numero_pase.HeaderText = "Pase No.";
            this.Numero_pase.Name = "Numero_pase";
            // 
            // id_conductor
            // 
            this.id_conductor.DataPropertyName = "Conductor";
            this.id_conductor.HeaderText = "Conductor";
            this.id_conductor.Name = "id_conductor";
            // 
            // id_secretaria
            // 
            this.id_secretaria.DataPropertyName = "id_secretaria";
            this.id_secretaria.HeaderText = "Secretaria";
            this.id_secretaria.Name = "id_secretaria";
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "Categoria";
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // expedicion
            // 
            this.expedicion.DataPropertyName = "Expedicion";
            this.expedicion.HeaderText = "Expedicion";
            this.expedicion.Name = "expedicion";
            // 
            // vencimiento
            // 
            this.vencimiento.DataPropertyName = "Vencimiento";
            this.vencimiento.HeaderText = "Caducidad";
            this.vencimiento.Name = "vencimiento";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "dd-MM-yy";
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimiento.Location = new System.Drawing.Point(147, 326);
            this.dtpVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(91, 22);
            this.dtpVencimiento.TabIndex = 42;
            // 
            // dtpExpedicion
            // 
            this.dtpExpedicion.CustomFormat = "dd-MM-yy";
            this.dtpExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpedicion.Location = new System.Drawing.Point(147, 266);
            this.dtpExpedicion.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpedicion.Name = "dtpExpedicion";
            this.dtpExpedicion.Size = new System.Drawing.Size(84, 22);
            this.dtpExpedicion.TabIndex = 41;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(147, 210);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(265, 24);
            this.cmbCategoria.TabIndex = 40;
            // 
            // cmbTransito
            // 
            this.cmbTransito.FormattingEnabled = true;
            this.cmbTransito.Location = new System.Drawing.Point(147, 160);
            this.cmbTransito.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTransito.Name = "cmbTransito";
            this.cmbTransito.Size = new System.Drawing.Size(265, 24);
            this.cmbTransito.TabIndex = 39;
            // 
            // cmbConductor
            // 
            this.cmbConductor.FormattingEnabled = true;
            this.cmbConductor.Location = new System.Drawing.Point(147, 110);
            this.cmbConductor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbConductor.Name = "cmbConductor";
            this.cmbConductor.Size = new System.Drawing.Size(265, 24);
            this.cmbConductor.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 326);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Vencimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Expedición";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tránsito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Conductor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Número de pase";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(147, 63);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(265, 22);
            this.txtNumero.TabIndex = 0;
            // 
            // AdministrarLicencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 554);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministrarLicencias";
            this.Text = "AdministrarLicencias";
            this.Load += new System.EventHandler(this.AdministrarLicencias_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero_pase;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_conductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_secretaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn expedicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
    }
}