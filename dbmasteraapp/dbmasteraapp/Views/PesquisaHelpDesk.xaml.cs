using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dbmasteraapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PesquisaHelpDesk : ContentPage
	{
		public PesquisaHelpDesk ()
		{
			InitializeComponent ();
		}

        private async void Button_Limpar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PesquisaHelpDesk());
        }
        private void Button_Buscar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultadoPesquisa());
        }   
    }
}