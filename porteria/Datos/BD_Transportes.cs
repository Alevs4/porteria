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
    public class BD_Transportes : Conexion
    {
        public static bool Guardar = false;
        public void BD_Registrar_Entrada_Transporte(EN_Transportes transporte)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("SP_REGISTRAR_TRANSPORTES", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@Nombre", transporte.NombreCompleto);
                cmd.Parameters.AddWithValue("@Rut", transporte.Rut);
                cmd.Parameters.AddWithValue("@Patente", transporte.Patente);
                cmd.Parameters.AddWithValue("@PatenteCarro", transporte.PatenteCarro);
                cmd.Parameters.AddWithValue("@Area", transporte.Area);
                cmd.Parameters.AddWithValue("@ResponsableIngreso", transporte.Responsable);
                cmd.Parameters.AddWithValue("@Fecha", transporte.Fecha);
                cmd.Parameters.AddWithValue("@HoIngreso", transporte.HoraEntrada);
                cmd.Parameters.AddWithValue("@GuiaEntrada", transporte.GuiaEntrada);
                cmd.Parameters.AddWithValue("@DetalleEntrada", transporte.DetalleEntrada);
                cmd.Parameters.AddWithValue("@GuiaSalida", transporte.GuiaSalida);
                cmd.Parameters.AddWithValue("@DetalleSalida", transporte.DetalleSalida);

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
        public void BD_Registrar_Salida_Transporte(EN_Transportes transporte)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("SP_REGISTRO_SALIDA_TRANSPORTES_PLANTA", cn);
            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //agregamos los parametros del precedimiento de almacenado
                cmd.Parameters.AddWithValue("@Id", transporte.Id_transporte);
                cmd.Parameters.AddWithValue("@Salida", transporte.HoraSalida);
                cmd.Parameters.AddWithValue("@GuiaSalida", transporte.GuiaSalida);
                cmd.Parameters.AddWithValue("@DetalleSalida", transporte.DetalleSalida);


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
        public DataTable BD_Leer_Entrada_Transportes()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_LISTAR_ENTRADA_TRANSPORTES", cn);
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
        public DataTable BD_Leer_Entrada_Transportes_XValor(string rut)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_BUSCAR_TRANSPORTE_ENTRADA_PLANTA", cn);
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
