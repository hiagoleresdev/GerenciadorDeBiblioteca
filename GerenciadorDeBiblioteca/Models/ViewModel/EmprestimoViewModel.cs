namespace GerenciadorDeBiblioteca.Models.ViewModel
{
    public class EmprestimoViewModel
    {
        public EmprestimoViewModel(int idUsuario, int idLivro, DateTime dataEmprestimo, DateTime dataDeDevolucao, bool ativo)
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

        public static EmprestimoViewModel FromEntity(Emprestimo e) => new EmprestimoViewModel(e.IdUsuario, e.IdLivro, e.DataEmprestimo, e.DataDeDevolucao, e.Ativo);

    }
}
