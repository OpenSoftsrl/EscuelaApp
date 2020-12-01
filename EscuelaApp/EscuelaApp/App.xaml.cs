using EscuelaApp.Models;
using EscuelaApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EscuelaApp
{
    public partial class App : Application
    {
        public static List<Alumno> Alumnos;

        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new ListaAlumnoView());
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
