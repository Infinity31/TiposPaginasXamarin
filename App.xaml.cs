using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TiposPaginasXamarin
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            NavigationPage main = new NavigationPage(new TiposPaginasXamarin.Views.MainNavigation());
            MainPage = main;
            //MainPage = new TiposPaginasXamarin.Views.Carousel();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
