namespace GerenciadorDeBiblioteca.Models
{
    public class Emprestimo
    {
        public Emprestimo()
        {
            DataEmprestimo = DateTime.Now;
        }

        public Guid Id { get; set; }

        public int IdUsuario { get; set; }

        public int IdLivro { get; set; }

        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDeDevolucao { get; set; }
    }
}
