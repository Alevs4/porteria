using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porteria
{
    public class Cls_Libreria
    {
        private int id;
        private static string nombre;
        private static string usuario;
        private static string pass;

        public int Id { get => id; set => id = value; }
        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Usuario { get => usuario; set => usuario = value; }
        public static string Pass { get => pass; set => pass = value; }
    }
}
