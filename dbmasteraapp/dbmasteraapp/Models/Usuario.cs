using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace dbmasteraapp.Models
{
    [Table("usuario")]
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250), Unique, NotNull]
        public string Login { get; set; }
        [MaxLength(300), NotNull]
        public string Senha { get; set; }
        [NotNull]
        public bool IsLogado { get; set; } = false;
        public DateTime UltimoAcesso { get; set; } = DateTime.Now;

        public static implicit operator Usuario(TableQuery<Usuario> v)
        {
            throw new NotImplementedException();
        }
    }
}
