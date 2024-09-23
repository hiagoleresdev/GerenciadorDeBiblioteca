using GerenciadorDeBiblioteca.Entities;

namespace GerenciadorDeBiblioteca.Models
{
    public class Livro : BaseEntity
    {
        public Livro() { }
        public Livro(string titulo, string autor, string isbn, int anoPublicacao)
            :base()
        {
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            AnoPublicacao = anoPublicacao;  
        }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }
    }
}
