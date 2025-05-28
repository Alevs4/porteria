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
using static System.Windows.Forms.MonthCalendar;

namespace porteria
{
    public partial class RegistroIngreso : Form
    {
        public RegistroIngreso()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botoneRedondos3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RegistroIngreso_Load(object sender, EventArgs e)
        {
            Acompañantes.Visible = false;
            ConfigurarListview();
            Cargar_Entrada_Visitas();
        }

        private void CheckAcompañantes_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckAcompañantes.Checked)
            {
                Acompañantes.Visible = true;
            }
            else
            {
                Acompañantes.Visible = false;
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
      
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

                if (string.IsNullOrWhiteSpace(TxtNombreVisitante.Text) ||
                string.IsNullOrWhiteSpace(TxtRut.Text) ||
                string.IsNullOrWhiteSpace(TxtPatente.Text) ||
                string.IsNullOrWhiteSpace(TxtEmpresa.Text) ||
                string.IsNullOrWhiteSpace(TxtRecepciona.Text) ||
                string.IsNullOrWhiteSpace(Fecha.Text) ||
                string.IsNullOrWhiteSpace(HoIngreso.Text) ||
                 string.IsNullOrWhiteSpace(TxtGuardia.Text)


          )

                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Guardar_Entrada_Visitas_Planta();
            
            }
       
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
        private void Guardar_Entrada_Visitas_Planta()
        {

            RN_Visitas obj = new RN_Visitas();
            EN_Visitas per = new EN_Visitas();

            try
            {
                per.NombreCompleto = TxtNombreVisitante.Text;
                per.Rut = TxtRut.Text;
                per.Patente = TxtPatente.Text;
                per.Empresa = TxtEmpresa.Text;
                per.Responsable = TxtRecepciona.Text;
                per.Fecha = Convert.ToDateTime(Fecha.Text);
                per.HoraEntrada = Convert.ToDateTime(HoIngreso.Text);
                per.Guardia= TxtGuardia.Text;
                per.Acompañante1 = TxtAcompañante1.Text;
                per.Acompañante2 = TxtAcompañante2.Text;
                per.Acompañante3 = TxtAcompañante3.Text;
                per.Acompañante4 = TxtAcompañante4.Text;
                per.Observaciones = TxtObservaciones.Text;


                obj.BD_Registrar_Entrada_Visitas(per);

                if (BD_Visitas.Guardar == true)
                {

                    MessageBox.Show("Persona Agregada Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Cargar_Entrada_Transportes();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void LlenarListview(DataTable data)
        {
            ListaVisitas.Items.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Visitas"].ToString());
                list.SubItems.Add(dr["Nombre_Completo"].ToString());
                list.SubItems.Add(dr["Rut"].ToString());
                list.SubItems.Add(dr["Patente"].ToString());
                list.SubItems.Add(dr["Empresa"].ToString());
                list.SubItems.Add(dr["ResponsableRecepcion"].ToString());
                list.SubItems.Add(dr["Fecha"].ToString());
                list.SubItems.Add(dr["HoIngreso"].ToString());
                list.SubItems.Add(dr["HoSalida"].ToString());
                list.SubItems.Add(dr["Guardia"].ToString());
     
                //Llenamos el listview
                ListaVisitas.Items.Add(list);
            }
            //Lbl_total.Text = Convert.ToString(ListaMateriales.Items.Count);
        }
        public void ConfigurarListview()
        {
            var lis = ListaVisitas;
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
            lis.Columns.Add("Empresa", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Responsable", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Hora Ingreso", 140, HorizontalAlignment.Left);
            lis.Columns.Add("Hora Salia", 140, HorizontalAlignment.Left);
            lis.Columns.Add("Guardia", 100, HorizontalAlignment.Left);


        }
        public void Cargar_Entrada_Visitas()
        {
            RN_Visitas obj = new RN_Visitas();
            DataTable dt = new DataTable();

            dt = obj.RN_Leer_Entrada_Visitas();
            if (dt.Rows.Count > 0)
            {
                LlenarListview(dt);
            }

        }
    }
}
