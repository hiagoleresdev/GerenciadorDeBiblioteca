using GerenciadorDeBiblioteca.Entities;

namespace GerenciadorDeBiblioteca.Models
{
    public class Emprestimo : BaseEntity
    {
        public Emprestimo(int idUsuario, int idLivro, DateTime dataEmprestimo, DateTime dataDeDevolucao)
            : base()
        {
            IdUsuario = idUsuario;
            IdLivro = idLivro;
            DataEmprestimo = dataEmprestimo;
            DataDeDevolucao = dataDeDevolucao;
        }

        public int IdUsuario { get; set; }

        public int IdLivro { get; set; }

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDeDevolucao { get; set; }

        public void Devolver()
        {
            DataDeDevolucao = DateTime.Now;
        }
    }
}
