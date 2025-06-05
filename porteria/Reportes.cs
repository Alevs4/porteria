using porteria.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using DGVPrinterHelper;

namespace porteria
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Reporte_Personal()
        {
            RN_Reportes reporte = new RN_Reportes();
            DataTable dt = new DataTable();
            if (CboTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CboTipo.SelectedItem.ToString() == "INGRESO PERSONAL")
            {
                dt = reporte.RN_Reporte_Personal();
                DgvReporte.DataSource = dt;
                DgvReporte.Columns[0].HeaderText = "Rut";
                DgvReporte.Columns[0].Width = 100; // Ajusta el ancho de la columna Rut
                DgvReporte.Columns[1].HeaderText = "Nombre";
                DgvReporte.Columns[1].Width = 150; // Ajusta el ancho de la columna Nombre
                DgvReporte.Columns[2].HeaderText = "Fecha";
                DgvReporte.Columns[2].Width = 80; // Ajusta el ancho de la columna Fecha
                DgvReporte.Columns[3].HeaderText = "Hora de Ingreso";
                DgvReporte.Columns[3].Width = 80; // Ajusta el ancho de la columna Hora de Ingreso
                DgvReporte.Columns[4].HeaderText = "Hora de Salida";
                DgvReporte.Columns[4].Width = 80; // Ajusta el ancho de la columna Hora de Salida

                DgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Desactiva el ajuste automático de columnas

            }
           else  if (CboTipo.SelectedItem.ToString() == "INGRESO TRANSPORTES")
            {
                dt = reporte.RN_Reporte_Transporte();
                DgvReporte.DataSource = dt;
                DgvReporte.Columns[0].HeaderText = "Nombre";
                DgvReporte.Columns[1].Width = 100; // Ajusta el ancho de la columna Nombre
                DgvReporte.Columns[1].HeaderText = "Rut";
                DgvReporte.Columns[1].Width = 80; // Ajusta el ancho de la columna Rut
                DgvReporte.Columns[2].HeaderText = "Patente";
                DgvReporte.Columns[2].Width = 60; // Ajusta el ancho de la columna Patente
                DgvReporte.Columns[3].HeaderText = "Patente Carro";
                DgvReporte.Columns[3].Width = 60; // Ajusta el ancho de la columna Patente Carr
                DgvReporte.Columns[4].HeaderText = "Area";
                DgvReporte.Columns[5].HeaderText = "Responsable";
                DgvReporte.Columns[5].Width = 100; // Ajusta el ancho de la columna Responsable
                DgvReporte.Columns[6].HeaderText = "Fecha";
                DgvReporte.Columns[6].Width = 70; // Ajusta el ancho de la columna Fecha
                DgvReporte.Columns[7].HeaderText = "Hora de Ingreso";
                DgvReporte.Columns[7].Width = 70; // Ajusta el ancho de la columna Hora de Ingreso
                DgvReporte.Columns[8].HeaderText = "Hora de Salida";
                DgvReporte.Columns[8].Width = 70; // Ajusta el ancho de la columna Hora de Salida
                DgvReporte.Columns[9].HeaderText = "Guia Entrada";
                DgvReporte.Columns[9].Width = 60; // Ajusta el ancho de la columna Guia Entrada
                DgvReporte.Columns[10].HeaderText = "Detalle Entrada";
                DgvReporte.Columns[10].Width = 80; // Ajusta el ancho de la columna Detalle Entrada
                DgvReporte.Columns[11].HeaderText = "Guia Salida";
                DgvReporte.Columns[11].Width = 60; // Ajusta el ancho de la columna Guia Salida
                DgvReporte.Columns[12].HeaderText = "Detalle Salida";
                DgvReporte.Columns[12].Width = 80; // Ajusta el ancho de la columna Detalle Salida

                DgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;



            }
            else if (CboTipo.SelectedItem.ToString() == "INGRESO VISITAS U OTROS")
            {
                dt = reporte.RN_Reporte_Visitas();
                DgvReporte.DataSource = dt;
                DgvReporte.Columns[0].HeaderText = "Nombre";
                DgvReporte.Columns[0].Width = 100; // Ajusta el ancho de la columna Nombre|
                DgvReporte.Columns[1].HeaderText = "Rut";
                DgvReporte.Columns[1].Width = 80; // Ajusta el ancho de la columna Rut
                DgvReporte.Columns[2].HeaderText = "Patente";
                DgvReporte.Columns[2].Width = 60; // Ajusta el ancho de la columna Patente
                DgvReporte.Columns[3].HeaderText = "Empresa";
                DgvReporte.Columns[3].Width = 100; // Ajusta el ancho de la columna Empresa
                DgvReporte.Columns[4].HeaderText = "Recepcion";
                DgvReporte.Columns[4].Width = 100; // Ajusta el ancho de la columna Recepcion
                DgvReporte.Columns[5].HeaderText = "Fecha";
                DgvReporte.Columns[5].Width = 70; // Ajusta el ancho de la columna Fecha
                DgvReporte.Columns[6].HeaderText = "Hora de Ingreso";
                DgvReporte.Columns[6].Width = 70; // Ajusta el ancho de la columna Hora de Ingreso
                DgvReporte.Columns[7].HeaderText = "Hora de Salida";
                DgvReporte.Columns[7].Width = 70; // Ajusta el ancho de la columna Hora de Salida

                DgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


            }

            else
            {
                MessageBox.Show("Seleccione un tipo de reporte válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void Reportes_Rango()
        {
            RN_Reportes reporte = new RN_Reportes();
            DataTable dt = new DataTable();

            if (CboTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de reporte.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CboTipo.SelectedItem.ToString() == "INGRESO PERSONAL")
            {
                dt = reporte.RN_Leer_Reporte_Personalo_Valor(Convert.ToDateTime(FechaInicio.Text), Convert.ToDateTime(FechaFin.Text));
                DgvReporte.DataSource = dt;
                DgvReporte.Columns[0].HeaderText = "Rut";
                DgvReporte.Columns[0].Width = 100;
                DgvReporte.Columns[1].HeaderText = "Nombre";
                DgvReporte.Columns[1].Width = 150;
                DgvReporte.Columns[2].HeaderText = "Fecha";
                DgvReporte.Columns[2].Width = 80;
                DgvReporte.Columns[3].HeaderText = "Hora de Ingreso";
                DgvReporte.Columns[3].Width = 80;
                DgvReporte.Columns[4].HeaderText = "Hora de Salida";
                DgvReporte.Columns[4].Width = 80;

                DgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


            }
            else if (CboTipo.SelectedItem.ToString() == "INGRESO TRANSPORTES")
            {
                dt = reporte.RN_Leer_Reporte_Transportes_Valor(Convert.ToDateTime(FechaInicio.Text), Convert.ToDateTime(FechaFin.Text));
                DgvReporte.DataSource = dt;
                DgvReporte.Columns[0].HeaderText = "Nombre";
                DgvReporte.Columns[0].Width = 100;
                DgvReporte.Columns[1].HeaderText = "RUT";
                DgvReporte.Columns[1].Width = 80;
                DgvReporte.Columns[2].HeaderText = "Patente";
                DgvReporte.Columns[2].Width = 60;
                DgvReporte.Columns[3].HeaderText = "Patente Carro";
                DgvReporte.Columns[3].Width = 60;
                DgvReporte.Columns[4].HeaderText = "Área";
                DgvReporte.Columns[4].Width = 80;
                DgvReporte.Columns[5].HeaderText = "Responsable Ingreso";
                DgvReporte.Columns[5].Width = 100;
                DgvReporte.Columns[6].HeaderText = "Fecha";
                DgvReporte.Columns[6].Width = 70;
                DgvReporte.Columns[7].HeaderText = "Hora Ingreso";
                DgvReporte.Columns[7].Width = 70;
                DgvReporte.Columns[8].HeaderText = "Hora Salida";
                DgvReporte.Columns[8].Width = 70;
                DgvReporte.Columns[9].HeaderText = "Guía Entrada";
                DgvReporte.Columns[9].Width = 60;
                DgvReporte.Columns[10].HeaderText = "Detalles Entrada";
                DgvReporte.Columns[10].Width = 80;
                DgvReporte.Columns[11].HeaderText = "Guía Salida";
                DgvReporte.Columns[11].Width = 60;
                DgvReporte.Columns[12].HeaderText = "Detalles Salida";
                DgvReporte.Columns[12].Width = 80;

                // Desactiva el ajuste automático si lo tenías activado
                DgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;


            }
            else if (CboTipo.SelectedItem.ToString() == "INGRESO VISITAS U OTROS")
            {
                dt = reporte.RN_Leer_Reporte_Visitas_Valor(Convert.ToDateTime(FechaInicio.Text),Convert.ToDateTime(FechaFin.Text));
                DgvReporte.DataSource = dt;
                DgvReporte.Columns[0].HeaderText = "Nombre";
                DgvReporte.Columns[0].Width = 100;
                DgvReporte.Columns[1].HeaderText = "Rut";
                DgvReporte.Columns[1].Width = 80;
                DgvReporte.Columns[2].HeaderText = "Patente";
                DgvReporte.Columns[2].Width = 60;
                DgvReporte.Columns[3].HeaderText = "Empresa";
                DgvReporte.Columns[3].Width = 100;
                DgvReporte.Columns[4].HeaderText = "Recepcion";
                DgvReporte.Columns[4].Width = 100;
                DgvReporte.Columns[5].HeaderText = "Fecha";
                DgvReporte.Columns[5].Width = 70;
                DgvReporte.Columns[6].HeaderText = "Hora de Ingreso";
                DgvReporte.Columns[6].Width = 70;
                DgvReporte.Columns[7].HeaderText = "Hora de Salida";
                DgvReporte.Columns[7].Width = 70;

                DgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            }

            else
            {
                MessageBox.Show("Seleccione un tipo de reporte válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBuscarReporte_Click(object sender, EventArgs e)
        {
            Reportes_Rango();
        }

        private void ExportarExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        DataTable dt = (DataTable)DgvReporte.DataSource;
                        wb.Worksheets.Add(dt, "Reportes Porteria");
                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Reporte exportado a Excel exitosamente.");
                }
            }
        }

        private void BtnMostrarTodo_Click(object sender, EventArgs e)
        {
            Reporte_Personal();
        }

        private void botoneRedondos2_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter(); // Ensure the DGVPrinterHelper library is referenced in your project
            printer.Title = "Reporte Porteria"; // Example title
            printer.SubTitle = "Actividad Entrada y Salida Planta Fruttita"; // Example subtitle
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Porteria"; // Example footer
            printer.FooterSpacing = 15;

            printer.PrintDataGridView(DgvReporte); // Ensure DataSalidaMat is a DataGridView
        }
    }
}
