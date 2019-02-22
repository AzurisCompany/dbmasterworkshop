using dbmasteraapp.Models;
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
            var projetoList = new List<Projeto>();
            projetoList.Add(new Projeto { Codigo = 1, Descricao = "Crm" });
            projetoList.Add(new Projeto { Codigo = 2, Descricao = "Portal cliente" });
            projetoList.Add(new Projeto { Codigo = 3, Descricao = "Portal vendas" });
            ProjetosTela.ItemsSource = projetoList;



            var statusList = new List<Status>();
            statusList.Add(new Status { Codigo = 1, Descricao = "Aberto" });
            statusList.Add(new Status { Codigo = 2, Descricao = "Em Atendimento" });
            statusList.Add(new Status { Codigo = 3, Descricao = "Validação Cliente" });
            StatusTela.ItemsSource = statusList;


        }

        private async void Button_Limpar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PesquisaHelpDesk());
        }
        private void Button_Buscar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ResultadoPesquisa());
        }

        private void btnNovoChamado_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CriarChamado());
        }
    }
}