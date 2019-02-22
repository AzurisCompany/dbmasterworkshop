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
    public partial class CriarChamado : ContentPage
    {
        public CriarChamado()
        {   
            InitializeComponent();

            var projetos = new List<Projeto>();
            projetos.Add(new Projeto { Codigo = 1, Descricao = "Crm" });
            projetos.Add(new Projeto { Codigo = 1, Descricao = "Portal cliente" });
            projetos.Add(new Projeto { Codigo = 1, Descricao = "Portal vendas" });
            PickerProjeto.ItemsSource = projetos;
            var tipoChamado = new List<TipoChamado>();
            tipoChamado.Add(new TipoChamado { Codigo = 1, Descricao = "Desenvolvimento" });
            tipoChamado.Add(new TipoChamado { Codigo = 1, Descricao = "Manutenção" });
            tipoChamado.Add(new TipoChamado { Codigo = 1, Descricao = "Sugestão" });
            PickerTipo.ItemsSource = tipoChamado;
            var maquinas = new List<Maquina>();
            maquinas.Add(new Maquina { Codigo = 1, Descricao = "Máquina 1" });
            maquinas.Add(new Maquina { Codigo = 1, Descricao = "Máquina 2" });
            maquinas.Add(new Maquina { Codigo = 1, Descricao = "Máquina 3" });
            PickerMaquina.ItemsSource = maquinas;
          
        }
    }
}