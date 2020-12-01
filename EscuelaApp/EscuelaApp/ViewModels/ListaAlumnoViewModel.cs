using EscuelaApp.Models;
using EscuelaApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EscuelaApp.ViewModels
{
    public class ListaAlumnoViewModel : BaseViewModel
    {

        private ObservableCollection<Alumno> alumnos;
        public ObservableCollection<Alumno> Alumnos
        {
            get => alumnos;
            set
            {
                alumnos = value;
                OnPropertyChanged();
            }
        }

        private Alumno alumnoSeleccionado;
        public Alumno AlumnoSeleccionado 
        {
            get => alumnoSeleccionado;
            set
            {
                alumnoSeleccionado = value;
                OnPropertyChanged();
            }
        }

        public ICommand cmdCargarDatos { get; private set; }
        public ICommand cmdVerDetalles { get; private set; }
        public ICommand cmdNuevoDato { get; private set; }
        public INavigation Navigation { get; }

        public ListaAlumnoViewModel(INavigation navigation)
        {
            Navigation = navigation;
            cmdCargarDatos = new Command(async () => await CargarDatos());
            cmdVerDetalles = new Command<Type>(async (p) => await VerDetalles(p));
            cmdNuevoDato = new Command<Type>(async (p) => await CrearNuevoDato(p));
        }

        private async Task CargarDatos()
        {
            IsBusy = true;
            
            await Task.Delay(2000);

            var lista = ServicioAlumnos.ObtenerAlumnnos();
            Alumnos = new ObservableCollection<Alumno>(lista);
            IsBusy = false;
        }

        private async Task VerDetalles(Type pagina)
        {
            if(alumnoSeleccionado!=null)
            {
                var page = (Page)Activator.CreateInstance(pagina);
                page.BindingContext = new AlumnoViewModel(AlumnoSeleccionado);
                await Navigation.PushAsync(page);
            }
        }

        private async Task CrearNuevoDato(Type pagina)
        {
            var page = (Page)Activator.CreateInstance(pagina);
            var vm = new AlumnoViewModel();
            page.BindingContext = vm;
            await Navigation.PushAsync(page);
        }
    }
}
