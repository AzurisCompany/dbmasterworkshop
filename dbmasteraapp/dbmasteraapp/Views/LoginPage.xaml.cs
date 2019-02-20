using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            MessagingCenter.Send<object>(this, App.EVENT_LAUNCH_MAIN_PAGE);
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