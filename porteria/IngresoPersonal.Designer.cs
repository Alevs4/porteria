namespace porteria
{
    partial class IngresoPersonal
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
            this.label9 = new System.Windows.Forms.Label();
            this.TxtBuscarPersonalPlanta = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.HoraIngreso = new System.Windows.Forms.DateTimePicker();
            this.lab = new System.Windows.Forms.Label();
            this.TxtRut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombrePersonal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDia = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HoraSalida = new System.Windows.Forms.DateTimePicker();
            this.ListaIngresoPer = new System.Windows.Forms.ListView();
            this.LblId = new System.Windows.Forms.Label();
            this.BtnActualizar = new porteria.Componentes.BotoneRedondos();
            this.BtnCancelar = new porteria.Componentes.BotoneRedondos();
            this.BtnEditarSalida = new porteria.Componentes.BotoneRedondos();
            this.BtnRegistrar = new porteria.Componentes.BotoneRedondos();
            this.BtnSalir = new porteria.Componentes.BotoneRedondos();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(774, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 20);
            this.label9.TabIndex = 111;
            this.label9.Text = "Buscar";
            // 
            // TxtBuscarPersonalPlanta
            // 
            this.TxtBuscarPersonalPlanta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarPersonalPlanta.Location = new System.Drawing.Point(893, 81);
            this.TxtBuscarPersonalPlanta.Name = "TxtBuscarPersonalPlanta";
            this.TxtBuscarPersonalPlanta.Size = new System.Drawing.Size(371, 27);
            this.TxtBuscarPersonalPlanta.TabIndex = 110;
            this.TxtBuscarPersonalPlanta.TextChanged += new System.EventHandler(this.TxtBuscarPersonalPlanta_TextChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(2138, 70);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(99, 42);
            this.btnCerrar.TabIndex = 109;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(404, 686);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(721, 16);
            this.label7.TabIndex = 106;
            this.label7.Text = "_________________________________________________________________________________" +
    "_____________________";
            // 
            // HoraIngreso
            // 
            this.HoraIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraIngreso.Location = new System.Drawing.Point(274, 359);
            this.HoraIngreso.Name = "HoraIngreso";
            this.HoraIngreso.Size = new System.Drawing.Size(163, 24);
            this.HoraIngreso.TabIndex = 105;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(23, 298);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(55, 20);
            this.lab.TabIndex = 104;
            this.lab.Text = "Fecha";
            // 
            // TxtRut
            // 
            this.TxtRut.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRut.ForeColor = System.Drawing.Color.DimGray;
            this.TxtRut.Location = new System.Drawing.Point(274, 217);
            this.TxtRut.Margin = new System.Windows.Forms.Padding(4);
            this.TxtRut.Name = "TxtRut";
            this.TxtRut.Size = new System.Drawing.Size(163, 29);
            this.TxtRut.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 100;
            this.label3.Text = "Rut";
            // 
            // TxtNombrePersonal
            // 
            this.TxtNombrePersonal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombrePersonal.ForeColor = System.Drawing.Color.DimGray;
            this.TxtNombrePersonal.Location = new System.Drawing.Point(274, 141);
            this.TxtNombrePersonal.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNombrePersonal.Name = "TxtNombrePersonal";
            this.TxtNombrePersonal.Size = new System.Drawing.Size(473, 29);
            this.TxtNombrePersonal.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 99;
            this.label2.Text = "Nombre Y Apellido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1546, 66);
            this.panel1.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(557, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Control de Ingreso Personal Fruttita";
            // 
            // FechaDia
            // 
            this.FechaDia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDia.Location = new System.Drawing.Point(274, 296);
            this.FechaDia.Name = "FechaDia";
            this.FechaDia.Size = new System.Drawing.Size(163, 24);
            this.FechaDia.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 359);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Hora Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 428);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 117;
            this.label5.Text = "Hora Salida";
            // 
            // HoraSalida
            // 
            this.HoraSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraSalida.Location = new System.Drawing.Point(274, 424);
            this.HoraSalida.Name = "HoraSalida";
            this.HoraSalida.Size = new System.Drawing.Size(163, 24);
            this.HoraSalida.TabIndex = 116;
            // 
            // ListaIngresoPer
            // 
            this.ListaIngresoPer.HideSelection = false;
            this.ListaIngresoPer.Location = new System.Drawing.Point(754, 146);
            this.ListaIngresoPer.Name = "ListaIngresoPer";
            this.ListaIngresoPer.Size = new System.Drawing.Size(822, 491);
            this.ListaIngresoPer.TabIndex = 121;
            this.ListaIngresoPer.UseCompatibleStateImageBehavior = false;
            this.ListaIngresoPer.SelectedIndexChanged += new System.EventHandler(this.ListaIngresoPer_SelectedIndexChanged);
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Location = new System.Drawing.Point(31, 97);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(0, 16);
            this.LblId.TabIndex = 122;
            this.LblId.Visible = false;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnActualizar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnActualizar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnActualizar.BorderRadius = 15;
            this.BtnActualizar.BorderSize = 0;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.Color.White;
            this.BtnActualizar.Location = new System.Drawing.Point(582, 260);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(150, 60);
            this.BtnActualizar.TabIndex = 123;
            this.BtnActualizar.Text = "Actualizar Lista";
            this.BtnActualizar.TextColor = System.Drawing.Color.White;
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Gray;
            this.BtnCancelar.BackgroundColor = System.Drawing.Color.Gray;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancelar.BorderRadius = 15;
            this.BtnCancelar.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(476, 547);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(150, 60);
            this.BtnCancelar.TabIndex = 120;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextColor = System.Drawing.Color.White;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnEditarSalida
            // 
            this.BtnEditarSalida.BackColor = System.Drawing.Color.Teal;
            this.BtnEditarSalida.BackgroundColor = System.Drawing.Color.Teal;
            this.BtnEditarSalida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEditarSalida.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEditarSalida.BorderRadius = 15;
            this.BtnEditarSalida.BorderSize = 0;
            this.BtnEditarSalida.FlatAppearance.BorderSize = 0;
            this.BtnEditarSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditarSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarSalida.ForeColor = System.Drawing.Color.White;
            this.BtnEditarSalida.Location = new System.Drawing.Point(274, 547);
            this.BtnEditarSalida.Name = "BtnEditarSalida";
            this.BtnEditarSalida.Size = new System.Drawing.Size(150, 60);
            this.BtnEditarSalida.TabIndex = 119;
            this.BtnEditarSalida.Text = "Editar Hora Salida";
            this.BtnEditarSalida.TextColor = System.Drawing.Color.White;
            this.BtnEditarSalida.UseVisualStyleBackColor = false;
            this.BtnEditarSalida.Click += new System.EventHandler(this.BtnEditarSalida_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRegistrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnRegistrar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnRegistrar.BorderRadius = 15;
            this.BtnRegistrar.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(67, 547);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(150, 60);
            this.BtnRegistrar.TabIndex = 118;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.TextColor = System.Drawing.Color.White;
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Red;
            this.BtnSalir.BackgroundColor = System.Drawing.Color.Red;
            this.BtnSalir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSalir.BorderRadius = 0;
            this.BtnSalir.BorderSize = 0;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.ForeColor = System.Drawing.Color.White;
            this.BtnSalir.Location = new System.Drawing.Point(1328, 75);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(115, 40);
            this.BtnSalir.TabIndex = 113;
            this.BtnSalir.Text = "Cerrar";
            this.BtnSalir.TextColor = System.Drawing.Color.White;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // IngresoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1612, 772);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.ListaIngresoPer);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnEditarSalida);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HoraSalida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FechaDia);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtBuscarPersonalPlanta);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HoraIngreso);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.TxtRut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombrePersonal);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresoPersonal";
            this.Text = "IngresoPersonal";
            this.Load += new System.EventHandler(this.IngresoPersonal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBuscarPersonalPlanta;
        internal System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker HoraIngreso;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox TxtRut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombrePersonal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Componentes.BotoneRedondos BtnSalir;
        private System.Windows.Forms.DateTimePicker FechaDia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker HoraSalida;
        private Componentes.BotoneRedondos BtnRegistrar;
        private Componentes.BotoneRedondos BtnEditarSalida;
        private Componentes.BotoneRedondos BtnCancelar;
        private System.Windows.Forms.ListView ListaIngresoPer;
        private System.Windows.Forms.Label LblId;
        private Componentes.BotoneRedondos BtnActualizar;
    }
}