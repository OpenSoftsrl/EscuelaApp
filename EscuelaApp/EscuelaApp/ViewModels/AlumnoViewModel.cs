using Acr.UserDialogs;
using EscuelaApp.Models;
using EscuelaApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EscuelaApp.ViewModels
{
    public class AlumnoViewModel : BaseViewModel
    {
        public ICommand cmdAgregar { get; private set; }
        public ICommand cmdActualizar { get; private set; }
        public ICommand cmdEliminar { get; private set; }

        private Alumno alumno;

        public string Nombre
        {
            get => alumno.Nombre; //get { return alumno.Nombre; }
            set { alumno.Nombre = value; OnPropertyChanged(); }
        }
            
        public int Semestre
        {
            get => alumno.Semestre;
            set { alumno.Semestre = value; OnPropertyChanged(); }
        }

        public string Foto
        {
            get => alumno.Foto;
            set { alumno.Foto = value; OnPropertyChanged(); }
        }

        public DateTime FechaIngreso
        {
            get => alumno.FechaIngreso;
            set { alumno.FechaIngreso = value; OnPropertyChanged(); }
        }

        private Carrera carreraSeleccionada;
        public Carrera CarreraSeleccionada
        {
            get => carreraSeleccionada;
            set
            {
                carreraSeleccionada = value;
                alumno.IdCarrera = carreraSeleccionada.IdCarrera;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Carrera> carreras;
        public ObservableCollection<Carrera> Carreras
        {
            get => carreras;
            set { carreras = value; OnPropertyChanged(); }
        }

        public bool EsAlumnoNuevo => (alumno.IdAlumno == 0);
        public bool NoEsAlumnoNuevo => !EsAlumnoNuevo;


        public AlumnoViewModel(Alumno a=null)
        {
            alumno = a ?? new Alumno() { IdAlumno = 0, IdCarrera = 0 };

            //if (alumno != null)
            //    alumno = a;
            //else
            //    new Alumno() { IdAlumno = 0, IdCarrera = 0 };

            var lista = ServicioCarreras.ObtenerCarreras();
            Carreras = new ObservableCollection<Carrera>(lista);

            if (alumno.IdCarrera == 0)
                CarreraSeleccionada = Carreras.First();
            else
                CarreraSeleccionada = Carreras.First(x => x.IdCarrera == alumno.IdCarrera);

            cmdAgregar = new Command(async () => await Agregar());
            cmdActualizar = new Command(async () => await Actualizar());
            cmdEliminar = new Command(async () => await Eliminar());
        }

        private async Task Agregar()
        {
            IsBusy = true;

            App.Alumnos.Add(alumno);

            await UserDialogs.Instance.AlertAsync("Alumno dado de alta", "Correcto", "OK");
            
            IsBusy = false;
        }

        private async Task Actualizar()
        {
            IsBusy = true;
            await UserDialogs.Instance.AlertAsync("Alumno editado con éxtito", "Correcto", "OK");
            IsBusy = false;
        }

        private async Task Eliminar()
        {
            if(await UserDialogs.Instance.ConfirmAsync($"Realmente deseas eliminar a {alumno.Nombre}?", "Confirmar", "Sí", "No"))
            {
                IsBusy = true;

                App.Alumnos.Remove(alumno);

                await UserDialogs.Instance.AlertAsync("Alumno removido con éxito", "Correcto", "OK");

                IsBusy = false;
            }
        }


    }
}
