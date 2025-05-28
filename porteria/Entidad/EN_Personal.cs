using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porteria.Entidad
{
    public class EN_Personal
    {
        int _idpersonal;
        string _rut;
        string _Nombres;
        DateTime _fecha;
        DateTime _horaIngreso;
        DateTime _horaSalida;

        public int Idpersonal { get => _idpersonal; set => _idpersonal = value; }
        public string Rut { get => _rut; set => _rut = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public DateTime HoraIngreso { get => _horaIngreso; set => _horaIngreso = value; }
        public DateTime HoraSalida { get => _horaSalida; set => _horaSalida = value; }
    }
}
