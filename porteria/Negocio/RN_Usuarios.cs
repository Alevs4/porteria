using porteria.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porteria.Negocio
{
    public class RN_Usuarios
    {
        public DataTable RN_Lerr_Datos_Usuario(string Usuario)
        {
            BD_Usuarios obj = new BD_Usuarios();
            return obj.BD_Lerr_Datos_Usuario(Usuario);
        }
        public bool RN_Verificar_Acceso(string Usuario, string Contraseña)
        {
            BD_Usuarios obj = new BD_Usuarios();
            return obj.BD_Verificar_Acceso(Usuario, Contraseña);
        }
    }
}
