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
    public class RN_Visitas
    {
        public void BD_Registrar_Entrada_Visitas(EN_Visitas visitas)
        {
            BD_Visitas bd = new BD_Visitas();
            bd.BD_Registrar_Entrada_Visitas(visitas);
        }
        public DataTable RN_Leer_Entrada_Visitas()
        {
            BD_Visitas bd = new BD_Visitas();
            return bd.BD_Leer_Entrada_Visitas();
        }
        public DataTable RN_Leer_Entrada_Visitas_Valor(string rut)
        {
            BD_Visitas bd = new BD_Visitas();
            return bd.BD_Leer_Entrada_Visitas_Valor(rut);
        }
    }
}
