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
    public partial class ListaCarrerasView : ContentPage
    {
        ListaCarrerasViewModel vm;
        public ListaCarrerasView()
        {
            InitializeComponent();
            vm = new ListaCarrerasViewModel();
            BindingContext = vm;
        }

        private void bntSalir_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            vm.cmdLoadData.Execute(null);
        }
    }
}