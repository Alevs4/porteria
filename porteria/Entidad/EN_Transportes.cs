﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace porteria.Entidad
{
    public class EN_Transportes
    {
        int id_transporte;
        string rut;
        string nombreCompleto;
        DateTime fecha;
        string patente;
        string patenteCarro;
        string area;
        string responsable;
        DateTime horaEntrada;
        DateTime horaSalida;
        string guiaEntrada;
        string guiaSalida;
        string detalleEntrada;
        string detalleSalida;
        string acompañante1;
        string acompañante2;
        string acompañante3;
        string acompañante4;

        public int Id_transporte { get => id_transporte; set => id_transporte = value; }
        public string Rut { get => rut; set => rut = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Patente { get => patente; set => patente = value; }
        public string PatenteCarro { get => patenteCarro; set => patenteCarro = value; }
        public string Area { get => area; set => area = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string GuiaEntrada { get => guiaEntrada; set => guiaEntrada = value; }
        public string GuiaSalida { get => guiaSalida; set => guiaSalida = value; }
        public string DetalleEntrada { get => detalleEntrada; set => detalleEntrada = value; }
        public string DetalleSalida { get => detalleSalida; set => detalleSalida = value; }
        public string Acompañante1 { get => acompañante1; set => acompañante1 = value; }
        public string Acompañante2 { get => acompañante2; set => acompañante2 = value; }
        public string Acompañante3 { get => acompañante3; set => acompañante3 = value; }
        public string Acompañante4 { get => acompañante4; set => acompañante4 = value; }
    }
}
