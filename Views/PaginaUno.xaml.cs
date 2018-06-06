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
	public partial class PaginaUno : ContentPage
	{
		public PaginaUno ()
		{
			InitializeComponent ();
            this.btndos.Clicked += Btndos_Clicked;
		}

        private void Btndos_Clicked(object sender, EventArgs e)
        {
            NavigationPage segunda = new NavigationPage(new PaginaDos());
            segunda.Title = "Segunda Página";
            Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(segunda));
        }
    }
}