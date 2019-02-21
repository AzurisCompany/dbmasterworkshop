using dbmasteraapp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace dbmasteraapp.Services
{
    public sealed class ConnSingleton
    {
        private static ConnSingleton dbInstance;
        private static readonly SQLiteConnection connection = null;

        private ConnSingleton()
        {
        }

        public static ConnSingleton GetDbInstance()
        {

            if (dbInstance == null)
            {
                dbInstance = new ConnSingleton();
            }
            return dbInstance;

        }

        public SQLiteConnection GetSQLiteConnection()
        {
            try
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Local_DBM_DBPortalCliente.db3");
                var conn = new SQLiteConnection(dbPath);
                conn.CreateTable<Usuario>();
                if (conn.Table<Usuario>().Count() == 0)
                {
                    var usuario = new Usuario
                    {
                        Login = "root",
                        Senha = "123"
                    };
                    conn.Insert(usuario);
                }
                return conn;
            }
            catch (Exception e)
            {
                Debug.Write(e);
            }
            return null;
        }
    }
}
