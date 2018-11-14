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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConductores = new System.Windows.Forms.Button();
            this.btnLicencias = new System.Windows.Forms.Button();
            this.btnSS = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCxT = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnKiometrajes = new System.Windows.Forms.Button();
            this.btnProducidos = new System.Windows.Forms.Button();
            this.btnSoats = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio Taxare";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSS);
            this.groupBox2.Controls.Add(this.btnLicencias);
            this.groupBox2.Controls.Add(this.btnConductores);
            this.groupBox2.Location = new System.Drawing.Point(7, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 105);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrar Conductores";
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
            // btnLicencias
            // 
            this.btnLicencias.Location = new System.Drawing.Point(161, 34);
            this.btnLicencias.Name = "btnLicencias";
            this.btnLicencias.Size = new System.Drawing.Size(110, 41);
            this.btnLicencias.TabIndex = 1;
            this.btnLicencias.Text = "Licencias";
            this.btnLicencias.UseVisualStyleBackColor = true;
            this.btnLicencias.Click += new System.EventHandler(this.btnLicencias_Click);
            // 
            // btnSS
            // 
            this.btnSS.Location = new System.Drawing.Point(296, 34);
            this.btnSS.Name = "btnSS";
            this.btnSS.Size = new System.Drawing.Size(127, 41);
            this.btnSS.TabIndex = 2;
            this.btnSS.Text = "Seguridad Social";
            this.btnSS.UseVisualStyleBackColor = true;
            this.btnSS.Click += new System.EventHandler(this.btnSS_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVehiculos);
            this.groupBox3.Controls.Add(this.btnSoats);
            this.groupBox3.Controls.Add(this.btnProducidos);
            this.groupBox3.Controls.Add(this.btnKiometrajes);
            this.groupBox3.Controls.Add(this.btnGastos);
            this.groupBox3.Controls.Add(this.btnCxT);
            this.groupBox3.Location = new System.Drawing.Point(7, 151);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 275);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Administrar Taxis";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnCxT
            // 
            this.btnCxT.Location = new System.Drawing.Point(26, 37);
            this.btnCxT.Name = "btnCxT";
            this.btnCxT.Size = new System.Drawing.Size(165, 56);
            this.btnCxT.TabIndex = 3;
            this.btnCxT.Text = "Conductores por taxi";
            this.btnCxT.UseVisualStyleBackColor = true;
            this.btnCxT.Click += new System.EventHandler(this.btnCxT_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.Location = new System.Drawing.Point(250, 37);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(173, 56);
            this.btnGastos.TabIndex = 4;
            this.btnGastos.Text = "Gastos";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnKiometrajes
            // 
            this.btnKiometrajes.Location = new System.Drawing.Point(26, 117);
            this.btnKiometrajes.Name = "btnKiometrajes";
            this.btnKiometrajes.Size = new System.Drawing.Size(165, 56);
            this.btnKiometrajes.TabIndex = 5;
            this.btnKiometrajes.Text = "Kilometrajes";
            this.btnKiometrajes.UseVisualStyleBackColor = true;
            this.btnKiometrajes.Click += new System.EventHandler(this.btnKiometrajes_Click);
            // 
            // btnProducidos
            // 
            this.btnProducidos.Location = new System.Drawing.Point(250, 117);
            this.btnProducidos.Name = "btnProducidos";
            this.btnProducidos.Size = new System.Drawing.Size(165, 56);
            this.btnProducidos.TabIndex = 6;
            this.btnProducidos.Text = "Producidos";
            this.btnProducidos.UseVisualStyleBackColor = true;
            this.btnProducidos.Click += new System.EventHandler(this.btnProducidos_Click);
            // 
            // btnSoats
            // 
            this.btnSoats.Location = new System.Drawing.Point(26, 198);
            this.btnSoats.Name = "btnSoats";
            this.btnSoats.Size = new System.Drawing.Size(165, 56);
            this.btnSoats.TabIndex = 7;
            this.btnSoats.Text = "Soats";
            this.btnSoats.UseVisualStyleBackColor = true;
            this.btnSoats.Click += new System.EventHandler(this.btnSoats_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.Location = new System.Drawing.Point(250, 198);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Size = new System.Drawing.Size(165, 56);
            this.btnVehiculos.TabIndex = 8;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.UseVisualStyleBackColor = true;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 487);
            this.Controls.Add(this.groupBox1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
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
    }
}