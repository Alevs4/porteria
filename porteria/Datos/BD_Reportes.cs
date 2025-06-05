using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porteria.Datos
{
    public class BD_Reportes : Conexion
    {
        public DataTable BD_Leer_Reporte_Transportes_Valor(DateTime fechaInicio,DateTime fechaFin)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_REPORTE_TRANSPORTES_FECHA_HORA", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin);
                //da.SelectCommand.Parameters.AddWithValue("@HoraInicio", horaInicio);
                //da.SelectCommand.Parameters.AddWithValue("@HoraFin", horaFin);
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
        public DataTable BD_Leer_Reporte_Personalo_Valor(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_REPORTE_PERSONAL_FECHA_HORA", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin);
                //da.SelectCommand.Parameters.AddWithValue("@HoraInicio", horaInicio);
                //da.SelectCommand.Parameters.AddWithValue("@HoraFin", horaFin);
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
        public DataTable BD_Leer_Reporte_Visitas_Valor(DateTime fechaInicio, DateTime fechaFin)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_REPORTE_VISITAS_FECHA_HORA", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                da.SelectCommand.Parameters.AddWithValue("@FechaFin", fechaFin);
                //da.SelectCommand.Parameters.AddWithValue("@HoraInicio", horaInicio);
                //da.SelectCommand.Parameters.AddWithValue("@HoraFin", horaFin);
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
        public DataTable BD_Reporte_Personal()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_LISTAR_ENTRADA_PERSONAs_REPORTE", cn);
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
        public DataTable BD_Reporte_Transporte()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_LISTAR_ENTRADA_TRANSPORTES_REPORTE", cn);
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
        public DataTable BD_Reporte_Visitas()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_LISTAR_ENTRADA_VISITAS_REPORTE", cn);
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

    }
}
