namespace TaxareProject
{
    partial class AdministrarSS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbVencidos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVencen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dgvSS = new System.Windows.Forms.DataGridView();
            this.dtpfinal = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActulizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.cmbConductor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_conductor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago_anterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pago_siguiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.dgvSS);
            this.groupBox1.Controls.Add(this.dtpfinal);
            this.groupBox1.Controls.Add(this.dtpInicio);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.btnActulizar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Controls.Add(this.cmbConductor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1139, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Seguridad Social";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox2.Controls.Add(this.cmbVencidos);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbVencen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblsum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 180);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info.";
            // 
            // cmbVencidos
            // 
            this.cmbVencidos.FormattingEnabled = true;
            this.cmbVencidos.Location = new System.Drawing.Point(15, 139);
            this.cmbVencidos.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVencidos.Name = "cmbVencidos";
            this.cmbVencidos.Size = new System.Drawing.Size(235, 24);
            this.cmbVencidos.TabIndex = 69;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 17);
            this.label7.TabIndex = 68;
            this.label7.Text = "Vencidas";
            // 
            // cmbVencen
            // 
            this.cmbVencen.FormattingEnabled = true;
            this.cmbVencen.Location = new System.Drawing.Point(15, 87);
            this.cmbVencen.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVencen.Name = "cmbVencen";
            this.cmbVencen.Size = new System.Drawing.Size(235, 24);
            this.cmbVencen.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 17);
            this.label6.TabIndex = 67;
            this.label6.Text = "Vencen en menos de dos dias";
            // 
            // lblsum
            // 
            this.lblsum.AutoSize = true;
            this.lblsum.BackColor = System.Drawing.Color.DarkOrange;
            this.lblsum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsum.Location = new System.Drawing.Point(187, 33);
            this.lblsum.Name = "lblsum";
            this.lblsum.Padding = new System.Windows.Forms.Padding(3);
            this.lblsum.Size = new System.Drawing.Size(54, 25);
            this.lblsum.TabIndex = 65;
            this.lblsum.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Monto total de SS pagas:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(169, 189);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(235, 22);
            this.txtValor.TabIndex = 63;
            // 
            // dgvSS
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSS.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_conductor,
            this.pago_anterior,
            this.pago_siguiente,
            this.valor});
            this.dgvSS.Location = new System.Drawing.Point(422, 21);
            this.dgvSS.Name = "dgvSS";
            this.dgvSS.RowTemplate.Height = 24;
            this.dgvSS.Size = new System.Drawing.Size(711, 276);
            this.dgvSS.TabIndex = 62;
            this.dgvSS.DoubleClick += new System.EventHandler(this.dgvSS_DoubleClick);
            // 
            // dtpfinal
            // 
            this.dtpfinal.CustomFormat = "dd-MM-yy";
            this.dtpfinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpfinal.Location = new System.Drawing.Point(169, 143);
            this.dtpfinal.Margin = new System.Windows.Forms.Padding(5);
            this.dtpfinal.Name = "dtpfinal";
            this.dtpfinal.Size = new System.Drawing.Size(235, 22);
            this.dtpfinal.TabIndex = 60;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "dd-MM-yy";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(169, 100);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(5);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(235, 22);
            this.dtpInicio.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 58;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(537, 365);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 28);
            this.btnLimpiar.TabIndex = 57;
            this.btnLimpiar.Text = "Restablecer";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnActulizar
            // 
            this.btnActulizar.Location = new System.Drawing.Point(668, 304);
            this.btnActulizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActulizar.Name = "btnActulizar";
            this.btnActulizar.Size = new System.Drawing.Size(110, 28);
            this.btnActulizar.TabIndex = 56;
            this.btnActulizar.Text = "Actualizar";
            this.btnActulizar.UseVisualStyleBackColor = true;
            this.btnActulizar.Click += new System.EventHandler(this.btnActulizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(537, 304);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 28);
            this.btnEliminar.TabIndex = 55;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(422, 304);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(95, 28);
            this.btnCrear.TabIndex = 54;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // cmbConductor
            // 
            this.cmbConductor.FormattingEnabled = true;
            this.cmbConductor.Location = new System.Drawing.Point(169, 54);
            this.cmbConductor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbConductor.Name = "cmbConductor";
            this.cmbConductor.Size = new System.Drawing.Size(235, 24);
            this.cmbConductor.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha pago siguiente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha pago anterior:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conductor:";
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Width = 48;
            // 
            // id_conductor
            // 
            this.id_conductor.DataPropertyName = "id_conductor";
            this.id_conductor.HeaderText = "Conductor";
            this.id_conductor.Name = "id_conductor";
            // 
            // pago_anterior
            // 
            this.pago_anterior.DataPropertyName = "pago_anterior";
            this.pago_anterior.HeaderText = "Pago anterior";
            this.pago_anterior.Name = "pago_anterior";
            // 
            // pago_siguiente
            // 
            this.pago_siguiente.DataPropertyName = "pago_siguiente";
            this.pago_siguiente.HeaderText = "Proximo Pago";
            this.pago_siguiente.Name = "pago_siguiente";
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // AdministrarSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 458);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdministrarSS";
            this.Text = "AdministrarSS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActulizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ComboBox cmbConductor;
        private System.Windows.Forms.DataGridView dgvSS;
        private System.Windows.Forms.DateTimePicker dtpfinal;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbVencen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbVencidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_conductor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago_anterior;
        private System.Windows.Forms.DataGridViewTextBoxColumn pago_siguiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}