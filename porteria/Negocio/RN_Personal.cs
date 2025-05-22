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
    public class RN_Personal
    {
        public void RN_Ingreso_Personal_Planta(EN_Personal Per)
        {
            BD_Personal bd = new BD_Personal();
            bd.BD_Ingreso_Personal_Planta(Per);
        }
        public DataTable RN_Leer_Entrada_Persona()
        {
            BD_Personal bd = new BD_Personal();
            return bd.BD_Leer_Entrada_Persona();
            
        }
        public DataTable RN_Buscar_Entrada_Personal_xValor(string valor)
        {
            BD_Personal bd = new BD_Personal();
            return bd.BD_Buscar_Entrada_Personal_xValor(valor);
        }
        public void RN_Editar_Hora_Estado_Personal_Planta(EN_Personal Per)
        {
            BD_Personal bd = new BD_Personal();
            bd.BD_Editar_Hora_Estado_Personal_Planta(Per);
        }
    }
}
