namespace porteria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.formularioRedondo1 = new porteria.Componentes.FormularioRedondo();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUsu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIngreso = new porteria.Componentes.BotoneRedondos();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formularioRedondo1
            // 
            this.formularioRedondo1.CornerRadius = 30;
            this.formularioRedondo1.TargetControl = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(14, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPass.Location = new System.Drawing.Point(402, 193);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(242, 34);
            this.TxtPass.TabIndex = 16;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // TxtUsu
            // 
            this.TxtUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsu.Location = new System.Drawing.Point(402, 114);
            this.TxtUsu.Name = "TxtUsu";
            this.TxtUsu.Size = new System.Drawing.Size(242, 34);
            this.TxtUsu.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.BtnSalir);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 63);
            this.panel1.TabIndex = 12;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.Location = new System.Drawing.Point(628, 3);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(56, 50);
            this.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSalir.TabIndex = 2;
            this.BtnSalir.TabStop = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingreso";
            // 
            // BtnIngreso
            // 
            this.BtnIngreso.BackColor = System.Drawing.Color.Green;
            this.BtnIngreso.BackgroundColor = System.Drawing.Color.Green;
            this.BtnIngreso.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnIngreso.BorderRadius = 15;
            this.BtnIngreso.BorderSize = 0;
            this.BtnIngreso.FlatAppearance.BorderSize = 0;
            this.BtnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngreso.ForeColor = System.Drawing.Color.White;
            this.BtnIngreso.Location = new System.Drawing.Point(274, 282);
            this.BtnIngreso.Name = "BtnIngreso";
            this.BtnIngreso.Size = new System.Drawing.Size(221, 43);
            this.BtnIngreso.TabIndex = 18;
            this.BtnIngreso.Text = "Ingresar";
            this.BtnIngreso.TextColor = System.Drawing.Color.White;
            this.BtnIngreso.UseVisualStyleBackColor = false;
            this.BtnIngreso.Click += new System.EventHandler(this.BtnIngreso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 349);
            this.Controls.Add(this.BtnIngreso);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.FormularioRedondo formularioRedondo1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Componentes.BotoneRedondos BtnIngreso;
    }
}

