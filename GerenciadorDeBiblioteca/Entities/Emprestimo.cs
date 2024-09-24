using GerenciadorDeBiblioteca.Entities;

namespace GerenciadorDeBiblioteca.Models
{
    public class Emprestimo : BaseEntity
    {
        public Emprestimo(int idUsuario, int idLivro, DateTime dataEmprestimo, DateTime dataDeDevolucao, bool ativo)
            : base()
        {
            IdUsuario = idUsuario;
            IdLivro = idLivro;
            DataEmprestimo = dataEmprestimo;
            DataDeDevolucao = dataDeDevolucao;
            Ativo = ativo;
        }

        public int IdUsuario { get; set; }

        public int IdLivro { get; set; }

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDeDevolucao { get; set; }

        public bool Ativo { get; set; }

        public void Devolver()
        {
            DataDeDevolucao = DateTime.Now;
            Ativo = false;
        }
    }
}
