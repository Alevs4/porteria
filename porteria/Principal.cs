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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void AbrirFormularioEnPanel<TMiform>() where TMiform : Form, new()
        {
            Form formulario = panelFormularios.Controls.OfType<TMiform>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new TMiform
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void BtnIngresoPersonal_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<IngresoPersonal>();
        }

        private void BtnIngresoTransportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<IngresoTransportes>();
        }

        private void BtnRegistroIngreso_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<RegistroIngreso>();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel<Reportes>();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult Mensaje = MessageBox.Show("Estas seguro que quiere cerrar la APP", "Requerimiento del Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (Mensaje == DialogResult.OK)
                Application.Exit();
        }
    }
}
