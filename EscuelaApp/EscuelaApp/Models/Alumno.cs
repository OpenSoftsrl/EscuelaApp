using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaApp.Models
{
    public class Alumno
    {
        public int IdAlumno { get; set; }

        public string Nombre { get; set; }

        public int Semestre { get; set; }

        public string Foto { get; set; }

        public DateTime FechaIngreso { get; set; }

        public int IdCarrera { get; set; }
    }
}
