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
            projetos.Add(new Projeto { Codigo = 1, Nome = "Crm" });
            projetos.Add(new Projeto { Codigo = 1, Nome = "Portal cliente" });
            projetos.Add(new Projeto { Codigo = 1, Nome = "Portal vendas" });

            var tipoChamado = new List<TipoChamado>();
            tipoChamado.Add(new TipoChamado { Codigo = 1, Descricao = "Desenvolvimento" });
            tipoChamado.Add(new TipoChamado { Codigo = 1, Descricao = "Manutenção" });
            tipoChamado.Add(new TipoChamado { Codigo = 1, Descricao = "Sugestão" });

            var maquinas = new List<Maquina>();
            maquinas.Add(new Maquina { Codigo = 1, Nome = "Máquina 1" });
            maquinas.Add(new Maquina { Codigo = 1, Nome = "Máquina 2" });
            maquinas.Add(new Maquina { Codigo = 1, Nome = "Máquina 3" });

            var pickerProjeto = new Picker { Title = "Projeto" };
            pickerProjeto.ItemsSource = projetos;
            pickerProjeto.ItemDisplayBinding = new Binding("Nome");

            var pickerTipo = new Picker { Title = "Tipo chamado" };
            pickerTipo.ItemsSource = tipoChamado;
            pickerTipo.ItemDisplayBinding = new Binding("Descricao");

            var pickerMaquina = new Picker { Title = "Maquina" };
            pickerMaquina.ItemsSource = maquinas;
            pickerMaquina.ItemDisplayBinding = new Binding("Nome");


            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "", FontSize=Device.GetNamedSize(NamedSize.Large, typeof(Label)) },
                        pickerProjeto,
                    new Label { Text = "", FontSize=Device.GetNamedSize(NamedSize.Large, typeof(Label)) },
                       pickerTipo,
                    new Label { Text = "", FontSize=Device.GetNamedSize(NamedSize.Large, typeof(Label)) },
                       pickerMaquina


                }
            };


        }
    }
}