using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TiposPaginasXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainNavigation : ContentPage
	{
		public MainNavigation ()
		{
			InitializeComponent ();
            this.btncontent.Clicked += Btncontent_Clicked;
            this.btntabbed.Clicked += Btntabbed_Clicked;
            this.btncarousel.Clicked += Btncarousel_Clicked;
		}

        private void Btncarousel_Clicked(object sender, EventArgs e)
        {
            NavigationPage primera = new NavigationPage(new Carousel());
            primera.Title = "Página Carousel";
            Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(primera));
        }

        private void Btntabbed_Clicked(object sender, EventArgs e)
        {
            NavigationPage primera = new NavigationPage(new Tabbed());
            primera.Title = "Página Tabbed";
            Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(primera));
        }

        private void Btncontent_Clicked(object sender, EventArgs e)
        {
            NavigationPage primera = new NavigationPage(new Content());
            primera.Title = "Página Content";
            Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(primera));
        }
        
    }
}