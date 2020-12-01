using EscuelaApp.ViewModels;
using EscuelaApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EscuelaApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //this.BindingContext = new MainViewModel();
        }

        private void btnAlumnos_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ListaAlumnoView());
        }

        private void btnCarreras_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new ListaCarrerasView());
        }
    }
}
