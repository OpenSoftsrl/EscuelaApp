using EscuelaApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscuelaApp.Services
{
    public class ServicioCarreras
    {
        public static List<Carrera>ObtenerCarreras()
        {
            return new List<Carrera>()
            {
                new Carrera {IdCarrera=1, Nombre="Ing. Sistemas"},
                new Carrera {IdCarrera=2, Nombre="Ing. Informática"},
                new Carrera {IdCarrera=3, Nombre="Ing. Civil"},
                new Carrera {IdCarrera=4, Nombre="Lic. Economía"},
                new Carrera {IdCarrera=5, Nombre="Lic. Auditoría"},
                new Carrera {IdCarrera=6, Nombre="Lic. Farmacia"},
                new Carrera {IdCarrera=7, Nombre="Lic. Administración de empresas"},
                new Carrera {IdCarrera=8, Nombre="Ing. Comercial"},
                new Carrera {IdCarrera=9, Nombre="Lic. Arquitectura"},
                new Carrera {IdCarrera=10, Nombre="Lic. Matemáticas"},
                new Carrera {IdCarrera=11, Nombre="Lic. Física"},
                new Carrera {IdCarrera=12, Nombre="Ing. Alimentos"},
                new Carrera {IdCarrera=13, Nombre="Ing. Agronomía"},
                new Carrera {IdCarrera=14, Nombre="Ing. Forestal"},
                new Carrera {IdCarrera=15, Nombre="Ing. Mecatrónica"},
                new Carrera {IdCarrera=16, Nombre="Lic. Enfermería"}
            };
        }
    }
}
