using dbmasteraapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace dbmasteraapp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ChamadoDetalhePage : ContentPage
	{

		public ChamadoDetalhePage ()
		{            
            InitializeComponent ();
            GetChamado();
		}

        private void GetChamado()
        {
            Chamado t = new Chamado();
            t.Codigo = 211681;
            t.Titulo = "treinamento mobile";
            t.Descricao = "treinamento mobile treinamento mobile treinamento mobile";
            t.DataInclusao = new DateTime(2019, 2, 20, 17, 04, 0);
            t.DataAlteracao = new DateTime(2019, 2, 21, 8, 38, 0);
            t.Categoria = "Informação";
            t.Status = 1;
            t.Projeto = "Treinamento";
            t.Responsavel = new Usuario();
            t.Responsavel.Nome = "Anderson Sidor";
            t.Criador = new Usuario();
            t.Criador.Nome = "Anderson Sidor";
            t.TipoChamado = "Capacitação/Repasse";
            t.Prioridade = 0;
            t.Comentarios = new List<Comentario>();
            Comentario c = new Comentario();
            c.Codigo = 1;
            c.Descricao = "caminho web service SVN \n\n\nhttp://svn.dbmaster.com.br/svn/Clientes/DBMaster/Mobile/trunk/server/dbmasterws";
            c.DataInclusao = new DateTime(2019, 2, 21, 8, 38, 56);
            c.UsuarioInclusao = new Usuario();
            c.UsuarioInclusao.Nome = "Anderson Sidor";
            t.Comentarios.Add(c);
            this.BindingContext = t;
        }
	}
}