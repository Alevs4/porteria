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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool ValidarTexbox()
        {
            if (TxtUsu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtUsu.Focus();
                return false;

            }
            if (TxtPass.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresa tu Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtPass.Focus();
                return false;

            }
            return true;
        }
        private void AccederAlSistema()
        {
            RN_Usuarios obj = new RN_Usuarios();
            DataTable dt = new DataTable();
            int veces = 0;

            if (ValidarTexbox() == false)
                return;

            string usu, pass;
            usu = TxtUsu.Text.Trim();
            pass = TxtPass.Text.Trim();

            if (obj.RN_Verificar_Acceso(usu, pass) == true)
            {
                //los datos son correctos
                //MessageBox.Show("Bienvenido al Sistema", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cls_Libreria.Usuario = usu;

                dt = obj.RN_Lerr_Datos_Usuario(usu);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    Cls_Libreria.Nombre = Convert.ToString(dr["nombre"]);

                }


                Principal principal = new Principal();
                this.Hide();
                principal.Show();


            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtUsu.Text = "";
                TxtPass.Text = "";
                TxtUsu.Focus();
                veces += 1;

                if (veces == 3)
                {
                    MessageBox.Show("Numero de intentos Superado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngreso_Click(object sender, EventArgs e)
        {
            AccederAlSistema();
        }
    }
}
