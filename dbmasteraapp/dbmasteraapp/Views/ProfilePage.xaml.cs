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
    public partial class ProfilePage : ContentPage
    {

        public string Nome { get; } = "Usuário Teste";
        public string Email { get; } = "email@email.com.br";
        public string Telefone { get; } = "(41) 99999-9999";

        public ProfilePage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void BtnSalvar_Clicked(object sender, EventArgs e)
        {

        }
    }
}