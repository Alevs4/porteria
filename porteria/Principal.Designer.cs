namespace porteria
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblReloj = new System.Windows.Forms.Label();
            this.BtnReportes = new porteria.Componentes.BotoneRedondos();
            this.BtnRegistroIngreso = new porteria.Componentes.BotoneRedondos();
            this.BtnIngresoTransportes = new porteria.Componentes.BotoneRedondos();
            this.BtnIngresoPersonal = new porteria.Componentes.BotoneRedondos();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.BtnSalir);
            this.panel2.Location = new System.Drawing.Point(-103, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2032, 86);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(846, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro Actividad de Porteria";
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(1927, 22);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(53, 46);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSalir.TabIndex = 0;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.Color.White;
            this.panelFormularios.Controls.Add(this.pictureBox2);
            this.panelFormularios.Location = new System.Drawing.Point(242, 73);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(1684, 856);
            this.panelFormularios.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1684, 853);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(91, 794);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(85, 29);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "label3";
            // 
            // lblReloj
            // 
            this.lblReloj.AutoSize = true;
            this.lblReloj.BackColor = System.Drawing.Color.Transparent;
            this.lblReloj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloj.Location = new System.Drawing.Point(90, 712);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(98, 32);
            this.lblReloj.TabIndex = 1;
            this.lblReloj.Text = "label2";
            // 
            // BtnReportes
            // 
            this.BtnReportes.BackColor = System.Drawing.Color.Teal;
            this.BtnReportes.BackgroundColor = System.Drawing.Color.Teal;
            this.BtnReportes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnReportes.BorderRadius = 15;
            this.BtnReportes.BorderSize = 0;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.Location = new System.Drawing.Point(31, 519);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(166, 72);
            this.BtnReportes.TabIndex = 7;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.TextColor = System.Drawing.Color.White;
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnRegistroIngreso
            // 
            this.BtnRegistroIngreso.BackColor = System.Drawing.Color.Teal;
            this.BtnRegistroIngreso.BackgroundColor = System.Drawing.Color.Teal;
            this.BtnRegistroIngreso.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRegistroIngreso.BorderRadius = 15;
            this.BtnRegistroIngreso.BorderSize = 0;
            this.BtnRegistroIngreso.FlatAppearance.BorderSize = 0;
            this.BtnRegistroIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistroIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistroIngreso.ForeColor = System.Drawing.Color.White;
            this.BtnRegistroIngreso.Location = new System.Drawing.Point(31, 406);
            this.BtnRegistroIngreso.Name = "BtnRegistroIngreso";
            this.BtnRegistroIngreso.Size = new System.Drawing.Size(166, 73);
            this.BtnRegistroIngreso.TabIndex = 6;
            this.BtnRegistroIngreso.Text = "Registro Ingreso Visitas";
            this.BtnRegistroIngreso.TextColor = System.Drawing.Color.White;
            this.BtnRegistroIngreso.UseVisualStyleBackColor = false;
            this.BtnRegistroIngreso.Click += new System.EventHandler(this.BtnRegistroIngreso_Click);
            // 
            // BtnIngresoTransportes
            // 
            this.BtnIngresoTransportes.BackColor = System.Drawing.Color.Teal;
            this.BtnIngresoTransportes.BackgroundColor = System.Drawing.Color.Teal;
            this.BtnIngresoTransportes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnIngresoTransportes.BorderRadius = 15;
            this.BtnIngresoTransportes.BorderSize = 0;
            this.BtnIngresoTransportes.FlatAppearance.BorderSize = 0;
            this.BtnIngresoTransportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresoTransportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresoTransportes.ForeColor = System.Drawing.Color.White;
            this.BtnIngresoTransportes.Location = new System.Drawing.Point(31, 292);
            this.BtnIngresoTransportes.Name = "BtnIngresoTransportes";
            this.BtnIngresoTransportes.Size = new System.Drawing.Size(166, 74);
            this.BtnIngresoTransportes.TabIndex = 5;
            this.BtnIngresoTransportes.Text = "Ingreso de Transportes";
            this.BtnIngresoTransportes.TextColor = System.Drawing.Color.White;
            this.BtnIngresoTransportes.UseVisualStyleBackColor = false;
            this.BtnIngresoTransportes.Click += new System.EventHandler(this.BtnIngresoTransportes_Click);
            // 
            // BtnIngresoPersonal
            // 
            this.BtnIngresoPersonal.BackColor = System.Drawing.Color.Teal;
            this.BtnIngresoPersonal.BackgroundColor = System.Drawing.Color.Teal;
            this.BtnIngresoPersonal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnIngresoPersonal.BorderRadius = 15;
            this.BtnIngresoPersonal.BorderSize = 0;
            this.BtnIngresoPersonal.FlatAppearance.BorderSize = 0;
            this.BtnIngresoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresoPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresoPersonal.ForeColor = System.Drawing.Color.White;
            this.BtnIngresoPersonal.Location = new System.Drawing.Point(31, 177);
            this.BtnIngresoPersonal.Name = "BtnIngresoPersonal";
            this.BtnIngresoPersonal.Size = new System.Drawing.Size(166, 76);
            this.BtnIngresoPersonal.TabIndex = 4;
            this.BtnIngresoPersonal.Text = "Ingreso Personal Fruttita";
            this.BtnIngresoPersonal.TextColor = System.Drawing.Color.White;
            this.BtnIngresoPersonal.UseVisualStyleBackColor = false;
            this.BtnIngresoPersonal.Click += new System.EventHandler(this.BtnIngresoPersonal_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1926, 941);
            this.Controls.Add(this.BtnReportes);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.BtnRegistroIngreso);
            this.Controls.Add(this.BtnIngresoTransportes);
            this.Controls.Add(this.BtnIngresoPersonal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelFormularios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            this.panelFormularios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblReloj;
        private Componentes.BotoneRedondos BtnIngresoPersonal;
        private Componentes.BotoneRedondos BtnIngresoTransportes;
        private Componentes.BotoneRedondos BtnRegistroIngreso;
        private Componentes.BotoneRedondos BtnReportes;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}