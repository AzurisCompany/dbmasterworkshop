using System;
using System.Collections.Generic;
using System.Text;

namespace dbmasteraapp.Models
{
    public class Comentario
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; set; }
        public Usuario UsuarioInclusao { get; set; }
    }
}
