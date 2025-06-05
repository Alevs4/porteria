using porteria.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porteria.Datos
{
    public class BD_Visitas : Conexion
    {
        public static bool Guardar = false;
        public void BD_Registrar_Entrada_Visitas(EN_Visitas visitas)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("SP_REGISTRAR_VISITAS", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@Nombre", visitas.NombreCompleto);
                cmd.Parameters.AddWithValue("@Rut", visitas.Rut);
                cmd.Parameters.AddWithValue("@Patente", visitas.Patente);
                cmd.Parameters.AddWithValue("@Empresa", visitas.Empresa);
                cmd.Parameters.AddWithValue("@ResponsableIngreso", visitas.Responsable);
                cmd.Parameters.AddWithValue("@Fecha", visitas.Fecha);
                cmd.Parameters.AddWithValue("@HoIngreso", visitas.HoraEntrada);
                cmd.Parameters.AddWithValue("@Guardia", visitas.Guardia);
                cmd.Parameters.AddWithValue("@Acompañante1", visitas.Acompañante1);
                cmd.Parameters.AddWithValue("@Acompañante2", visitas.Acompañante2);
                cmd.Parameters.AddWithValue("@Acompañante3", visitas.Acompañante3);
                cmd.Parameters.AddWithValue("@Acompañante4", visitas.Acompañante4);
                cmd.Parameters.AddWithValue("@Observaciones", visitas.Observaciones);


                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Guardar = true;

            }
            catch (Exception ex)
            {
                Guardar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void BD_Registrar_Salida_Visitas(EN_Visitas visitas)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("SP_REGISTRO_SALIDA_VISITAS_PLANTA", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@Id", visitas.Id_Visitas);
                cmd.Parameters.AddWithValue("@Salida", visitas.HoraSalida);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                Guardar = true;

            }
            catch (Exception ex)
            {
                Guardar = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public DataTable BD_Leer_Entrada_Visitas()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_LISTAR_ENTRADA_VISITAS", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }
        public DataTable BD_Leer_Entrada_Visitas_Valor(string rut)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_BUSCAR_VISITA_ENTRADA_PLANTA", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id", rut);
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo Malo Pasó" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

    }
}
