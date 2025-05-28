using porteria.Datos;
using porteria.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porteria.Negocio
{
    public class RN_Transportes
    {
        public void RN_Registrar_Entrada_Transporte(EN_Transportes transporte)
        {
            BD_Transportes obj = new BD_Transportes();
            obj.BD_Registrar_Entrada_Transporte(transporte);
        }
        public DataTable RN_Leer_Entrada_Transportes()
        {
            BD_Transportes obj = new BD_Transportes();
            return  obj.BD_Leer_Entrada_Transportes();
           
        }
        public DataTable RN_Leer_Entrada_Transportes_XValor(string rut)
        {
            BD_Transportes obj = new BD_Transportes();
            return obj.BD_Leer_Entrada_Transportes_XValor(rut);
        }
        public void RN_Registrar_Salida_Transporte(EN_Transportes transporte)
        {
            BD_Transportes obj = new BD_Transportes();
            obj.BD_Registrar_Salida_Transporte(transporte);
        }
    }
}
