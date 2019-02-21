using dbmasteraapp.Models;
using dbmasteraapp.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace dbmasteraapp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private AuthenticationService authenticationService = new AuthenticationService();
        public LoginViewModel()
        {
            Title = "Login";

        }

        public bool Autenticar(Usuario usuario)
        {
            if (authenticationService.Autenticar(usuario).IsLogado)
                return true;
            return false;
        }
    }
}
