using porteria.Datos;
using porteria.Entidad;
using porteria.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace porteria
{
    public partial class IngresoPersonal : Form
    {
        public IngresoPersonal()
        {
            InitializeComponent();
        }

        private void IngresoPersonal_Load(object sender, EventArgs e)
        {
            ConfigurarListview();
            Cargar_Entrada_Personal();
            BtnEditarSalida.Enabled = false;
        }
        public void Cargar_Entrada_Personal()
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Leer_Entrada_Persona();
            if (dt.Rows.Count > 0)
            {
                LlenarListview(dt);
            }
        
     
        }
        private void Guardar_Entrada_Personal_Planta()
        {

            RN_Personal obj = new RN_Personal();
            EN_Personal per = new EN_Personal();

            try
            {
                per.Nombres = TxtNombrePersonal.Text;
                per.Rut = TxtRut.Text;
                per.Fecha = Convert.ToDateTime(FechaDia.Text);
                per.HoraIngreso =Convert.ToDateTime(HoraIngreso.Text);
          
     
                obj.RN_Ingreso_Personal_Planta(per);

                if (BD_Personal.Guardar == true)
                {

                    MessageBox.Show("Persona Agregada Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Entrada_Personal();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Guardar_Salida_Personal_Planta()
        {

            RN_Personal obj = new RN_Personal();
            EN_Personal per = new EN_Personal();

            try
            {
                per.Idpersonal = Convert.ToInt32(LblId.Text);
                per.HoraSalida =Convert.ToDateTime(HoraSalida.Text);


                obj.RN_Editar_Hora_Estado_Personal_Planta(per);

                if (BD_Personal.Guardar == true)
                {

                    MessageBox.Show("Salida Agregada Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Entrada_Personal();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditarSalida_Click(object sender, EventArgs e)
        {
            if (TxtNombrePersonal.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Nombre Completo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombrePersonal.Focus();
                return;
            }
            if (TxtRut.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Rut", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRut.Focus();
                return;
            }
            Guardar_Salida_Personal_Planta();
            TxtRut.Enabled = true;
            TxtNombrePersonal.Enabled = true;
            FechaDia.Enabled = true;
            HoraIngreso.Enabled = true;
            BtnRegistrar.Enabled = true;
            TxtRut.Text = "";
            TxtNombrePersonal.Text = "";
            LblId.Text = "";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtRut.Enabled = true;
            TxtNombrePersonal.Enabled = true;
            FechaDia.Enabled = true;
            HoraIngreso.Enabled = true;
            BtnRegistrar.Enabled = true;
            TxtRut.Text = "";
            TxtNombrePersonal.Text = "";
            LblId.Text = "";
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

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (TxtNombrePersonal.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Nombre Completo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombrePersonal.Focus();
                return;
            }
            if (TxtRut.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese Rut", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRut.Focus();
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

                Guardar_Entrada_Personal_Planta();
            }
        }

        private void TxtBuscarPersonalPlanta_TextChanged(object sender, EventArgs e)
        {
            if (TxtBuscarPersonalPlanta.Text.Trim().Length > 1)
            {
                Buscar_Entrada_Planta_PorValor(TxtBuscarPersonalPlanta.Text.Trim());
            }
            else
            {
                Cargar_Entrada_Personal();
            }
        }
        private void Buscar_Entrada_Planta_PorValor(string xvalor)
        {
            RN_Personal obj = new RN_Personal();
            DataTable dt = new DataTable();

            dt = obj.RN_Buscar_Entrada_Personal_xValor(xvalor);
            if (dt.Rows.Count > 0)
            {
                LlenarListview(dt);
            }
     
        }
        public void LlenarListview(DataTable data)
        {
            ListaIngresoPer.Items.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow dr = data.Rows[i];
                ListViewItem list = new ListViewItem(dr["Id_Per"].ToString());
                list.SubItems.Add(dr["Rut"].ToString());
                list.SubItems.Add(dr["NombreCompleto"].ToString());
                list.SubItems.Add(dr["Fecha"].ToString());
                list.SubItems.Add(dr["HoEntrada"].ToString());
                list.SubItems.Add(dr["HoSalida"].ToString());
              


                //Llenamos el listview
                ListaIngresoPer.Items.Add(list);
            }
            //Lbl_total.Text = Convert.ToString(ListaMateriales.Items.Count);
        }
        public void ConfigurarListview()
        {
            var lis = ListaIngresoPer;
            lis.Columns.Clear();
            lis.Items.Clear();
            lis.View = View.Details;
            lis.GridLines = false;
            lis.FullRowSelect = true;
            lis.Scrollable = true;
            lis.HideSelection = false;
            // configuramos el ancho y nombres de las columnas
            lis.Columns.Add("Id ", 40, HorizontalAlignment.Left);
            lis.Columns.Add("Rut", 100, HorizontalAlignment.Left);
            lis.Columns.Add("Nombre", 150, HorizontalAlignment.Left);
            lis.Columns.Add("Fecha", 80, HorizontalAlignment.Left);
            lis.Columns.Add("Hora Ingreso", 140, HorizontalAlignment.Left);
            lis.Columns.Add("Hora Salia", 140, HorizontalAlignment.Left);

        }

        private void ListaIngresoPer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaIngresoPer.SelectedItems.Count > 0)
            {
                ListViewItem item = ListaIngresoPer.SelectedItems[0];

                // Por ejemplo, mostrar la primera columna en el TextBox
                LblId.Text = item.SubItems[0].Text;
                TxtRut.Text = item.SubItems[1].Text;
                TxtNombrePersonal.Text = item.SubItems[2].Text;
                FechaDia.Text = item.SubItems[3].Text;
                HoraIngreso.Text = item.SubItems[4].Text;

                TxtRut.Enabled = false;
                TxtNombrePersonal.Enabled = false;
                FechaDia.Enabled = false;
                HoraIngreso.Enabled = false;
                BtnRegistrar.Enabled = false;
                BtnEditarSalida.Enabled = true;

            }
        }
    }
}
