using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using dbmasteraapp.ViewModels;
using dbmasteraapp.Custom;

namespace dbmasteraapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
    {
		public LoginPage()
		{
			InitializeComponent();
            LoginField.ReturnCommand = new Command(() => SenhaField.Focus());
            SenhaField.ReturnCommand = new Command(() => Login());
            LoginField.TextChanged += EnableLoginButton;
            SenhaField.TextChanged += EnableLoginButton;
		}

        private void BtnLogin_Clicked(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            LoginViewModel vm = new LoginViewModel();
            if (vm.Autenticar(new Models.Usuario() { Login = LoginField.Text, Senha = SenhaField.Text }))
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
            if (!string.IsNullOrWhiteSpace(LoginField.Text) && !string.IsNullOrWhiteSpace(SenhaField.Text))
            {
                btnLogin.IsEnabled = true;
            }
            else
            {
                btnLogin.IsEnabled = false;
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            StatusBarEffect.SetBackgroundColor(Color.Red);
            this.Effects.Add(new StatusBarEffect());
        }

    }
}