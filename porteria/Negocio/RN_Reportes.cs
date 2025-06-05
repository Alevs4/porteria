using porteria.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porteria.Negocio
{
    public class RN_Reportes
    {
        public DataTable RN_Reporte_Personal()
        {
            BD_Reportes result = new BD_Reportes();
            return result.BD_Reporte_Personal();
        }
        public DataTable RN_Reporte_Transporte()
        {
            BD_Reportes result = new BD_Reportes();
            return result.BD_Reporte_Transporte();
        }
        public DataTable RN_Reporte_Visitas()
        {
            BD_Reportes result = new BD_Reportes();
            return result.BD_Reporte_Visitas();
        }
        public DataTable RN_Leer_Reporte_Transportes_Valor(DateTime fechaInicio, DateTime fechaFin)
        {
            BD_Reportes result = new BD_Reportes();
            return result.BD_Leer_Reporte_Transportes_Valor(fechaInicio, fechaFin);
        }
        public DataTable RN_Leer_Reporte_Personalo_Valor(DateTime fechaInicio, DateTime fechaFin)
        {
            BD_Reportes result = new BD_Reportes();
            return result.BD_Leer_Reporte_Personalo_Valor(fechaInicio, fechaFin);
        }
        public DataTable RN_Leer_Reporte_Visitas_Valor(DateTime fechaInicio, DateTime fechaFin)
        {
            BD_Reportes result = new BD_Reportes();
            return result.BD_Leer_Reporte_Visitas_Valor(fechaInicio, fechaFin);
        }
    }
}
