using porteria.Datos;
using porteria.Entidad;
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

namespace porteria
{
    public partial class IngresoTransportes : Form
    {
        public IngresoTransportes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        public void Cargar_Entrada_Transportes()
        {
            RN_Transportes obj = new RN_Transportes();
            DataTable dt = new DataTable();

            dt = obj.RN_Leer_Entrada_Transportes();
            if (dt.Rows.Count > 0)
            {
                LlenarListview(dt);
            }

        }
        private void Guardar_Entrada_Transportes_Planta()
        {

            RN_Transportes obj = new RN_Transportes();
            EN_Transportes per = new EN_Transportes();

            try { 
                per.NombreCompleto = TxtNombreChofer.Text;
                per.Rut = TxtRut.Text;
                per.Patente = TxtPatente.Text;
                per.PatenteCarro = TxtPatenteCarro.Text;
                per.Area = TxtArea.Text;
                per.Responsable = TxtRecepcion.Text;
                per.Fecha = Convert.ToDateTime(Fecha.Text);
                per.HoraEntrada = Hoingreso.Text;
                per.GuiaEntrada = TxtGuiaEntrada.Text;
                per.DetalleEntrada = TxtDetalleEntrada.Text;
                per.GuiaSalida = TxtGuiaSalida.Text;
                per.DetalleSalida = TxtDetalleSalida.Text;


                obj.RN_Registrar_Entrada_Transporte(per);

                if (BD_Transportes.Guardar == true)
                {

                    MessageBox.Show("Persona Agregada Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Entrada_Transportes();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void LlenarListview(DataTable data)
        {
            ListaTransporte.Items.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_transporte"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["Rut"].ToString());
                list.SubItems.Add(dr["Patente"].ToString());
                list.SubItems.Add(dr["Patente_Carro"].ToString());
                list.SubItems.Add(dr["Area"].ToString());
                list.SubItems.Add(dr["Responsable_Ingreso"].ToString());
                list.SubItems.Add(dr["Fecha"].ToString());
                list.SubItems.Add(dr["HoIngreso"].ToString());
                list.SubItems.Add(dr["HoSalida"].ToString());
                list.SubItems.Add(dr["GuiaEntrada"].ToString());
                list.SubItems.Add(dr["DetallesEntrada"].ToString());
                list.SubItems.Add(dr["GuiaSalida"].ToString());
                list.SubItems.Add(dr["DetallesSalida"].ToString());



                //Llenamos el listview
                ListaTransporte.Items.Add(list);
            }
            //Lbl_total.Text = Convert.ToString(ListaMateriales.Items.Count);
        }
        public void ConfigurarListview()
        {
            var lis = ListaTransporte;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            // configuramos el ancho y nombres de las columnas
            lis.Columns.Add("Id ", 40, HorizontalAlignment.Left);
            lis.Columns.Add("Nombre", 150, HorizontalAlignment.Left);
            lis.Columns.Add("Rut", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Patente", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Patente Carro", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Area", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Responsable", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Hora Ingreso", 140, HorizontalAlignment.Left);
            lis.Columns.Add("Hora Salia", 140, HorizontalAlignment.Left);
            lis.Columns.Add("Guia Entrada", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Detalles Entrada", 140, HorizontalAlignment.Left);
            lis.Columns.Add("Guia Salida", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Detalles Salida", 140, HorizontalAlignment.Left);

        }

        private void BtnRegistrarTransporte_Click(object sender, EventArgs e)
        {

            if (TxtNombreChofer.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Nombre Completo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombreChofer.Focus();
                return;
            }
            if (TxtRut.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Rut", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRut.Focus();
                return;
            }
            if (TxtPatente.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Patente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPatente.Focus();
                return;
            }
            if (TxtPatenteCarro.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Patente Carro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtPatenteCarro.Focus();
                return;
            }
            if (TxtArea.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Area", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtArea.Focus();
                return;
            }
            if (TxtRecepcion.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Responsable de Recepcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRecepcion.Focus();
                return;
            }
            if (Fecha.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Fecha", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Fecha.Focus();
                return;
            }
            if (Hoingreso.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Hora de Ingreso", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Hoingreso.Focus();
                return;
            }
            if (HoSalida.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Hora de Salida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HoSalida.Focus();
                return;
            }
            if (TxtGuiaEntrada.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Guia de Entrada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtGuiaEntrada.Focus();
                return;
            }
            if (TxtDetalleEntrada.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Detalle de Entrada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDetalleEntrada.Focus();
                return;
            }
            if (TxtGuiaSalida.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Guia de Salida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtGuiaSalida.Focus();
                return;
            }
            if (TxtDetalleSalida.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Detalle de Salida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDetalleSalida.Focus();
                return;
            }


            bool respuesta = false;
            string rut = TxtRut.Text;
            TxtRut.Text = formatoRut(rut);
            rut = TxtRut.Text;
            respuesta = validarRut(rut);

            if (respuesta == false)
            {

                TxtRut.BackColor = Color.Red;
                MessageBox.Show("Rut Incorrecto");
                TxtRut.Text = "";
                TxtRut.BackColor = Color.White;
                TxtRut.Focus();
            }
            else
            {
                TxtRut.ForeColor = Color.Black;
                TxtRut.BackColor = Color.GreenYellow;
                MessageBox.Show("Rut OK");

                Guardar_Entrada_Transportes_Planta();
            }
           
        }

        private void IngresoTransportes_Load(object sender, EventArgs e)
        {
            ConfigurarListview();
            Cargar_Entrada_Transportes();
        }
        private string formatoRut(string rut)
        {
            int cont = 0;
            string format;
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            format = "-" + rut.Substring(rut.Length - 1);
            for (int i = rut.Length - 2; i >= 0; i--)
            {
                format = rut.Substring(i, 1) + format;
                cont++;
                if (cont == 3 && i != 0)
                {
                    format = "." + format;
                    cont = 0;
                }
            }
            return format;
        }


        private bool validarRut(string rut)
        {
            bool validacion = false;
            rut = rut.ToUpper();
            rut = rut.Replace(".", "");
            rut = rut.Replace("-", "");
            int rutAux = int.Parse(rut.Substring(0, rut.Length - 1));
            char dv = char.Parse(rut.Substring(rut.Length - 1, 1));
            int m = 0, s = 1;
            for (; rutAux != 0; rutAux /= 10)
            {
                s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
            }
            if (dv == (char)(s != 0 ? s + 47 : 75))
            {
                validacion = true;
            }
            return validacion;
        }
        private void Buscar_Entrada_Planta_PorValor(string xvalor)
        {
            RN_Transportes obj = new RN_Transportes();
            DataTable dt = new DataTable();

            dt = obj.RN_Leer_Entrada_Transportes_XValor(xvalor);
            if (dt.Rows.Count > 0)
            {
                LlenarListview(dt);
            }

        }

        private void TxxtBuscarTransportista_TextChanged(object sender, EventArgs e)
        {
            if (TxxtBuscarTransportista.Text.Trim().Length > 1)
            {
                Buscar_Entrada_Planta_PorValor(TxxtBuscarTransportista.Text.Trim());
            }
            else
            {
                Cargar_Entrada_Transportes();
            }
        }
    }
}
