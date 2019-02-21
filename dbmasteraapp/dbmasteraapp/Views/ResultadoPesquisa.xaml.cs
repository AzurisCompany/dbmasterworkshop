using dbmasteraapp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dbmasteraapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResultadoPesquisa : ContentPage
	{
        private ObservableCollection<Chamado> chamados = new ObservableCollection<Chamado>();
        public ResultadoPesquisa ()
		{
			InitializeComponent ();

            chamados.Add(new Chamado() { Titulo = "teste chamado 1", Codigo = 111111 });
            chamados.Add(new Chamado() { Titulo = "teste chamado 2", Codigo = 222222 });
            chamados.Add(new Chamado() { Titulo = "teste chamado 3", Codigo = 333333 });
            chamados.Add(new Chamado() { Titulo = "teste chamado 4", Codigo = 444444 });
            listViewChamado.ItemsSource = chamados;
        }

      

        private void listViewChamado_Refreshing(object sender, EventArgs e)
        {

        }

        private void listViewChamado_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            chamados.Add(new Chamado() { Titulo = "teste chamado 1", Codigo = 111111 });
            chamados.Add(new Chamado() { Titulo = "teste chamado 2", Codigo = 222222 });
            chamados.Add(new Chamado() { Titulo = "teste chamado 3", Codigo = 333333 });
            chamados.Add(new Chamado() { Titulo = "teste chamado 4", Codigo = 444444 });
            listViewChamado.ItemsSource = chamados;

        }
    }
}