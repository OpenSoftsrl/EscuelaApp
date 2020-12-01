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
    public class ListaCarrerasViewModel : BaseViewModel
    {

        private ObservableCollection<Carrera> carreras;
        public ObservableCollection<Carrera> Carreras
        {
            get => carreras;
            set
            {
                carreras = value;
                OnPropertyChanged();
            }
        }

        public ICommand cmdLoadData { get; private set; }
        public ICommand cmdAddRecord { get; private set; }

        public ListaCarrerasViewModel()
        {
            cmdLoadData = new Command(async () => await LoadData());
            cmdAddRecord = new Command<Type>(async (p) => await AddRecord(p));
        }

        private async Task AddRecord(Type pagina)
        {
            
        }

        private async Task LoadData()
        {
            var listaCarreras = ServicioCarreras.ObtenerCarreras();
            Carreras = new ObservableCollection<Carrera>(listaCarreras);
        }
    }
}
