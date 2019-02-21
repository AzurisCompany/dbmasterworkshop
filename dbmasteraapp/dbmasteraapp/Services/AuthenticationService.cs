using dbmasteraapp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace dbmasteraapp.Services
{
    public class AuthenticationService
    {
        ConnSingleton cs = ConnSingleton.GetDbInstance();

        public Usuario Autenticar(Usuario usuario)
        {
            SQLiteConnection conn = cs.GetSQLiteConnection();
            Console.WriteLine("Connection Established");
            var user = from u in conn.Table<Usuario>() where u.Login.ToUpper() == usuario.Login.ToUpper() && u.Senha == usuario.Senha select u;
            if (user.FirstOrDefault() != null)
            {
                usuario = user.FirstOrDefault();
                usuario.IsLogado = true;
            }
            return usuario;
        }
    }
}
