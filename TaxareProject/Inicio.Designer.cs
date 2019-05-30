namespace TaxareProject
{
    partial class Inicio
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.btnSoats = new System.Windows.Forms.Button();
            this.btnProducidos = new System.Windows.Forms.Button();
            this.btnKiometrajes = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnCxT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSS = new System.Windows.Forms.Button();
            this.btnLicencias = new System.Windows.Forms.Button();
            this.btnConductores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio Taxare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 77;
            this.label3.Text = "Todo en un solo lugar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVehiculos);
            this.groupBox3.Controls.Add(this.btnSoats);
            this.groupBox3.Controls.Add(this.btnProducidos);
            this.groupBox3.Controls.Add(this.btnKiometrajes);
            this.groupBox3.Controls.Add(this.btnGastos);
            this.groupBox3.Controls.Add(this.btnCxT);
            this.groupBox3.Location = new System.Drawing.Point(18, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 182);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administrar Taxis";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Location = new System.Drawing.Point(239, 130);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(141, 34);
            this.btnVehiculos.TabIndex = 8;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // btnSoats
            // 
            this.btnSoats.Location = new System.Drawing.Point(16, 130);
            this.btnSoats.Name = "btnSoats";
            this.btnSoats.Size = new System.Drawing.Size(151, 34);
            this.btnSoats.TabIndex = 7;
            this.btnSoats.Text = "Soats";
            this.btnSoats.UseVisualStyleBackColor = true;
            this.btnSoats.Click += new System.EventHandler(this.btnSoats_Click);
            // 
            // btnProducidos
            // 
            this.btnProducidos.Location = new System.Drawing.Point(239, 87);
            this.btnProducidos.Name = "btnProducidos";
            this.btnProducidos.Size = new System.Drawing.Size(141, 31);
            this.btnProducidos.TabIndex = 6;
            this.btnProducidos.Text = "Producidos";
            this.btnProducidos.UseVisualStyleBackColor = true;
            this.btnProducidos.Click += new System.EventHandler(this.btnProducidos_Click);
            // 
            // btnKiometrajes
            // 
            this.btnKiometrajes.Location = new System.Drawing.Point(16, 87);
            this.btnKiometrajes.Name = "btnKiometrajes";
            this.btnKiometrajes.Size = new System.Drawing.Size(151, 31);
            this.btnKiometrajes.TabIndex = 5;
            this.btnKiometrajes.Text = "Kilometrajes";
            this.btnKiometrajes.UseVisualStyleBackColor = true;
            this.btnKiometrajes.Click += new System.EventHandler(this.btnKiometrajes_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Location = new System.Drawing.Point(239, 37);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(141, 34);
            this.btnGastos.TabIndex = 4;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnCxT
            // 
            this.btnCxT.Location = new System.Drawing.Point(16, 37);
            this.btnCxT.Name = "btnCxT";
            this.btnCxT.Size = new System.Drawing.Size(151, 34);
            this.btnCxT.TabIndex = 3;
            this.btnCxT.Text = "Conductores por taxi";
            this.btnCxT.UseVisualStyleBackColor = true;
            this.btnCxT.Click += new System.EventHandler(this.btnCxT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 29);
            this.label2.TabIndex = 76;
            this.label2.Text = "Puedes tomar el control de tu flota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 36);
            this.label1.TabIndex = 75;
            this.label1.Text = "Bienvenido a Taxare";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSS);
            this.groupBox2.Controls.Add(this.btnLicencias);
            this.groupBox2.Controls.Add(this.btnConductores);
            this.groupBox2.Location = new System.Drawing.Point(18, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 89);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrar Conductores";
            // 
            // btnSS
            // 
            this.btnSS.Location = new System.Drawing.Point(323, 34);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(127, 41);
            this.btnSS.TabIndex = 2;
            this.btnSS.Text = "Seguridad Social";
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // btnLicencias
            // 
            this.btnLicencias.Location = new System.Drawing.Point(178, 34);
            this.btnLicencias.Name = "btnLicencias";
            this.btnLicencias.Size = new System.Drawing.Size(110, 41);
            this.btnLicencias.TabIndex = 1;
            this.btnLicencias.Text = "Licencias";
            this.btnLicencias.UseVisualStyleBackColor = true;
            this.btnLicencias.Click += new System.EventHandler(this.btnLicencias_Click);
            // 
            // btnConductores
            // 
            this.btnConductores.Location = new System.Drawing.Point(7, 34);
            this.btnConductores.Name = "btnConductores";
            this.btnConductores.Size = new System.Drawing.Size(128, 41);
            this.btnConductores.TabIndex = 0;
            this.btnConductores.Text = "Conductores";
            this.btnConductores.UseVisualStyleBackColor = true;
            this.btnConductores.Click += new System.EventHandler(this.btnConductores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TaxareProject.Properties.Resources.Logo;
            this.pictureBox1.Image = global::TaxareProject.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(557, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnSoats;
        private System.Windows.Forms.Button btnProducidos;
        private System.Windows.Forms.Button btnKiometrajes;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.Button btnCxT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSS;
        private System.Windows.Forms.Button btnLicencias;
        private System.Windows.Forms.Button btnConductores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}