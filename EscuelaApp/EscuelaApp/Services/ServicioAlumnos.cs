using EscuelaApp.Models;
using System;
using System.Collections.Generic;

namespace EscuelaApp.Services
{
    public class ServicioAlumnos
    {
        public static List<Alumno> ObtenerAlumnnos()
        {
            if (App.Alumnos == null)
            {
                App.Alumnos = new List<Alumno>()
                {
                    new Alumno{IdAlumno=1, Foto="https://manugallegobarra.files.wordpress.com/2017/04/cropped-cropped-cropped-foto-perfil-2-redondo.png", Nombre="JUAN",IdCarrera=2, Semestre=1,FechaIngreso=DateTime.Now.AddDays(-50) },
                    new Alumno{IdAlumno=2, Foto="https://adsoncoach.com.br/wp-content/uploads/2018/07/foto-redonda-300x300.png", Nombre="JOSE",IdCarrera=4, Semestre=1,FechaIngreso=DateTime.Now.AddMonths(-5) },
                    new Alumno{IdAlumno=3, Foto="https://karinacaldas.com/wp-content/uploads/2019/07/PERFIL-REDONDA-300x300.png", Nombre="ALICIA",IdCarrera=1, Semestre=4,FechaIngreso=DateTime.Now.AddYears(-2) },
                    new Alumno{IdAlumno=4, Foto="https://www.lapi.com.mx/image.ashx?s=57067&sl=es&im=115321&st=p", Nombre="MARIA",IdCarrera=4, Semestre=2,FechaIngreso=DateTime.Now.AddDays(-80) },
                    new Alumno{IdAlumno=5, Foto="https://algorithmia.agency/wp-content/uploads/2019/03/perfil-hombre.png", Nombre="ABEL",IdCarrera=3, Semestre=5,FechaIngreso=new DateTime(2018, 2, 15) }
                };
            }
            return App.Alumnos;
        }
    }
}
