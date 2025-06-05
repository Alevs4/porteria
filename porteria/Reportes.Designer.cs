namespace porteria
{
    partial class Reportes
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
            this.FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvReporte = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FechaFin = new System.Windows.Forms.DateTimePicker();
            this.BtnMostrarTodo = new porteria.Componentes.BotoneRedondos();
            this.BtnBuscarReporte = new porteria.Componentes.BotoneRedondos();
            this.botoneRedondos2 = new porteria.Componentes.BotoneRedondos();
            this.ExportarExcel = new porteria.Componentes.BotoneRedondos();
            this.BtnSalir = new porteria.Componentes.BotoneRedondos();
            this.CboTipo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaInicio
            // 
            this.FechaInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicio.Location = new System.Drawing.Point(354, 166);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(163, 24);
            this.FechaInicio.TabIndex = 133;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1646, 66);
            this.panel1.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(707, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reportes";
            // 
            // DgvReporte
            // 
            this.DgvReporte.AllowUserToAddRows = false;
            this.DgvReporte.AllowUserToDeleteRows = false;
            this.DgvReporte.AllowUserToResizeColumns = false;
            this.DgvReporte.AllowUserToResizeRows = false;
            this.DgvReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvReporte.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvReporte.BackgroundColor = System.Drawing.Color.White;
            this.DgvReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvReporte.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvReporte.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvReporte.EnableHeadersVisualStyles = false;
            this.DgvReporte.Location = new System.Drawing.Point(39, 323);
            this.DgvReporte.MultiSelect = false;
            this.DgvReporte.Name = "DgvReporte";
            this.DgvReporte.ReadOnly = true;
            this.DgvReporte.RowHeadersVisible = false;
            this.DgvReporte.RowHeadersWidth = 51;
            this.DgvReporte.RowTemplate.Height = 24;
            this.DgvReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvReporte.Size = new System.Drawing.Size(1461, 501);
            this.DgvReporte.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(132, 852);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1253, 16);
            this.label7.TabIndex = 128;
            this.label7.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "_________________";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(391, 122);
            this.lab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(0, 25);
            this.lab.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 28);
            this.label2.TabIndex = 140;
            this.label2.Text = "Buscar por Fecha ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 233);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 22);
            this.label3.TabIndex = 141;
            this.label3.Text = "Seleccionar Reporte";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(712, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 145;
            this.label8.Text = "Hasta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(274, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 144;
            this.label9.Text = "Desde";
            // 
            // FechaFin
            // 
            this.FechaFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFin.Location = new System.Drawing.Point(792, 166);
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.Size = new System.Drawing.Size(163, 24);
            this.FechaFin.TabIndex = 146;
            // 
            // BtnMostrarTodo
            // 
            this.BtnMostrarTodo.BackColor = System.Drawing.Color.Navy;
            this.BtnMostrarTodo.BackgroundColor = System.Drawing.Color.Navy;
            this.BtnMostrarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMostrarTodo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnMostrarTodo.BorderRadius = 15;
            this.BtnMostrarTodo.BorderSize = 0;
            this.BtnMostrarTodo.FlatAppearance.BorderSize = 0;
            this.BtnMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMostrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarTodo.ForeColor = System.Drawing.Color.White;
            this.BtnMostrarTodo.Location = new System.Drawing.Point(1087, 215);
            this.BtnMostrarTodo.Name = "BtnMostrarTodo";
            this.BtnMostrarTodo.Size = new System.Drawing.Size(150, 40);
            this.BtnMostrarTodo.TabIndex = 147;
            this.BtnMostrarTodo.Text = "Mostrar todo";
            this.BtnMostrarTodo.TextColor = System.Drawing.Color.White;
            this.BtnMostrarTodo.UseVisualStyleBackColor = false;
            this.BtnMostrarTodo.Click += new System.EventHandler(this.BtnMostrarTodo_Click);
            // 
            // BtnBuscarReporte
            // 
            this.BtnBuscarReporte.BackColor = System.Drawing.Color.Gray;
            this.BtnBuscarReporte.BackgroundColor = System.Drawing.Color.Gray;
            this.BtnBuscarReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnBuscarReporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnBuscarReporte.BorderRadius = 15;
            this.BtnBuscarReporte.BorderSize = 0;
            this.BtnBuscarReporte.FlatAppearance.BorderSize = 0;
            this.BtnBuscarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarReporte.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarReporte.Location = new System.Drawing.Point(792, 215);
            this.BtnBuscarReporte.Name = "BtnBuscarReporte";
            this.BtnBuscarReporte.Size = new System.Drawing.Size(150, 40);
            this.BtnBuscarReporte.TabIndex = 139;
            this.BtnBuscarReporte.Text = "Buscar";
            this.BtnBuscarReporte.TextColor = System.Drawing.Color.White;
            this.BtnBuscarReporte.UseVisualStyleBackColor = false;
            this.BtnBuscarReporte.Click += new System.EventHandler(this.BtnBuscarReporte_Click);
            // 
            // botoneRedondos2
            // 
            this.botoneRedondos2.BackColor = System.Drawing.Color.Teal;
            this.botoneRedondos2.BackgroundColor = System.Drawing.Color.Teal;
            this.botoneRedondos2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botoneRedondos2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.botoneRedondos2.BorderRadius = 15;
            this.botoneRedondos2.BorderSize = 0;
            this.botoneRedondos2.FlatAppearance.BorderSize = 0;
            this.botoneRedondos2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botoneRedondos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoneRedondos2.ForeColor = System.Drawing.Color.White;
            this.botoneRedondos2.Location = new System.Drawing.Point(1516, 444);
            this.botoneRedondos2.Name = "botoneRedondos2";
            this.botoneRedondos2.Size = new System.Drawing.Size(150, 60);
            this.botoneRedondos2.TabIndex = 138;
            this.botoneRedondos2.Text = "Imprimir";
            this.botoneRedondos2.TextColor = System.Drawing.Color.White;
            this.botoneRedondos2.UseVisualStyleBackColor = false;
            this.botoneRedondos2.Click += new System.EventHandler(this.botoneRedondos2_Click);
            // 
            // ExportarExcel
            // 
            this.ExportarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ExportarExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ExportarExcel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ExportarExcel.BorderRadius = 15;
            this.ExportarExcel.BorderSize = 0;
            this.ExportarExcel.FlatAppearance.BorderSize = 0;
            this.ExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportarExcel.ForeColor = System.Drawing.Color.White;
            this.ExportarExcel.Location = new System.Drawing.Point(1516, 339);
            this.ExportarExcel.Name = "ExportarExcel";
            this.ExportarExcel.Size = new System.Drawing.Size(150, 60);
            this.ExportarExcel.TabIndex = 137;
            this.ExportarExcel.Text = "Exportar a Ecxel";
            this.ExportarExcel.TextColor = System.Drawing.Color.White;
            this.ExportarExcel.UseVisualStyleBackColor = false;
            this.ExportarExcel.Click += new System.EventHandler(this.ExportarExcel_Click);
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
            this.BtnSalir.Location = new System.Drawing.Point(1405, 90);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(115, 40);
            this.BtnSalir.TabIndex = 132;
            this.BtnSalir.Text = "Cerrar";
            this.BtnSalir.TextColor = System.Drawing.Color.White;
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // CboTipo
            // 
            this.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboTipo.FormattingEnabled = true;
            this.CboTipo.Items.AddRange(new object[] {
            "INGRESO PERSONAL",
            "INGRESO TRANSPORTES",
            "INGRESO VISITAS U OTROS"});
            this.CboTipo.Location = new System.Drawing.Point(262, 229);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Size = new System.Drawing.Size(301, 26);
            this.CboTipo.TabIndex = 142;
            this.CboTipo.SelectedIndexChanged += new System.EventHandler(this.CboTipo_SelectedIndexChanged);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 898);
            this.Controls.Add(this.BtnMostrarTodo);
            this.Controls.Add(this.FechaFin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CboTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnBuscarReporte);
            this.Controls.Add(this.botoneRedondos2);
            this.Controls.Add(this.ExportarExcel);
            this.Controls.Add(this.FechaInicio);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvReporte);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Componentes.BotoneRedondos BtnBuscarReporte;
        private Componentes.BotoneRedondos botoneRedondos2;
        private Componentes.BotoneRedondos ExportarExcel;
        private System.Windows.Forms.DateTimePicker FechaInicio;
        private Componentes.BotoneRedondos BtnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvReporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker FechaFin;
        private Componentes.BotoneRedondos BtnMostrarTodo;
        private System.Windows.Forms.ComboBox CboTipo;
    }
}