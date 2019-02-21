using dbmasteraapp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dbmasteraapp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Settings, Title="Settings" },
                new HomeMenuItem {Id = MenuItemType.PesquisaHelpDesk, Title="Pesquisa" },
                new HomeMenuItem {Id = MenuItemType.TicketDetail, Title="Ticket Detail" },
                new HomeMenuItem {Id = MenuItemType.CriarChamado, Title = "Novo Chamado" }
            };

            ListViewMenu.ItemsSource = menuItems;
            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }

        private async void Logout(object sender, EventArgs e)
        {
            if (await DisplayAlert("Sair", "Deseja sair do sistema?", "Sim", "Cancelar"))
            {
                try
                {
                    var existingPages = Navigation.NavigationStack.ToList();
                    foreach (var page in existingPages)
                    {
                        Navigation.RemovePage(page);
                    }
                    Preferences.Set("isLogged", false);
                    MessagingCenter.Send<object>(this, App.EVENT_LAUNCH_LOGIN_PAGE);

                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }


        }

    }
}