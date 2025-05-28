using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porteria.Entidad
{
    public class EN_Visitas
    {
        int id_Visitas;
        string rut;
        string nombreCompleto;
        DateTime fecha;
        string patente;
        string responsable;
        DateTime horaEntrada;
        DateTime horaSalida;
        string empresa;
        string guardia;
        string observaciones;
        string acompañante1;
        string acompañante2;
        string acompañante3;
        string acompañante4;

        public int Id_Visitas { get => id_Visitas; set => id_Visitas = value; }
        public string Rut { get => rut; set => rut = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Patente { get => patente; set => patente = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Guardia { get => guardia; set => guardia = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string Acompañante1 { get => acompañante1; set => acompañante1 = value; }
        public string Acompañante2 { get => acompañante2; set => acompañante2 = value; }
        public string Acompañante3 { get => acompañante3; set => acompañante3 = value; }
        public string Acompañante4 { get => acompañante4; set => acompañante4 = value; }
    }
}
