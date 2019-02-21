using System;
using System.Collections.Generic;
using System.Text;

namespace dbmasteraapp.Models
{
    public class Chamado
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInclusao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Categoria { get; set; }
        public int Status { get; set; }
        public string Projeto { get; set; }
        public string Maquina { get; set; }
        public Usuario Responsavel { get; set; }
        public Usuario Criador { get; set; }
        public string TipoChamado { get; set; }
        public int Prioridade { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}
