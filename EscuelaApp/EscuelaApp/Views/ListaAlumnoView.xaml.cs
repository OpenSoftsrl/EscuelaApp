using EscuelaApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EscuelaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaAlumnoView : ContentPage
    {

        ListaAlumnoViewModel vm;
        public ListaAlumnoView()
        {
            InitializeComponent();
            vm = new ListaAlumnoViewModel(this.Navigation);
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            vm.cmdCargarDatos.Execute(null);

        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}