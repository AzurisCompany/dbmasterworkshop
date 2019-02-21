using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using dbmasteraapp.ViewModels;

namespace dbmasteraapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
    {
		public LoginPage()
		{
			InitializeComponent();

            Login.TextChanged += EnableLoginButton;
            Senha.TextChanged += EnableLoginButton;
		}

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            LoginViewModel vm = new LoginViewModel();
            if (vm.Autenticar(new Models.Usuario() { Login = Login.Text, Senha = Senha.Text }))
            {
                Preferences.Set("isLogged", true);
                MessagingCenter.Send<object>(this, App.EVENT_LAUNCH_MAIN_PAGE);
            }
            else
            {
                DisplayAlert("Erro ao logar", "Por favor, confira o usuario e senha", "Ok");
            }
        }

        public void EnableLoginButton(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Login.Text) && !string.IsNullOrWhiteSpace(Senha.Text))
            {
                btnLogin.IsEnabled = true;
            }
            else
            {
                btnLogin.IsEnabled = false;
            }
        }

    }
}