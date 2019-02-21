using System;
using Xamarin.Forms;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;
using dbmasteraapp.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace dbmasteraapp
{
    public partial class App : Application
    {
        public static string EVENT_LAUNCH_LOGIN_PAGE = "EVENT_LAUNCH_LOGIN_PAGE";
        public static string EVENT_LAUNCH_MAIN_PAGE = "EVENT_LAUNCH_MAIN_PAGE";

        public App()
        {
            InitializeComponent();
            if (Preferences.Get("isLogged", false))
            {
                MainPage = new PesquisaHelpDesk();
            }
            else
            {
                MainPage = new LoginPage();
            }
            MainPage.SetValue(NavigationPage.BarBackgroundColorProperty, Color.Red); //COR DA BARRA DE STATUS

            MessagingCenter.Subscribe<object>(this, EVENT_LAUNCH_LOGIN_PAGE, SetLoginPageAsRootPage);
            MessagingCenter.Subscribe<object>(this, EVENT_LAUNCH_MAIN_PAGE, SetMainPageAsRootPage);
            
        }

        private void SetLoginPageAsRootPage(object sender)
        {
            MainPage = new LoginPage();
        }

        private void SetMainPageAsRootPage(object sender)
        {
            MainPage = new PesquisaHelpDesk();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
