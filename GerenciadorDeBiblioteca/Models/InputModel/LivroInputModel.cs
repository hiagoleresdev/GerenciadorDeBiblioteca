using GerenciadorDeBiblioteca.Models;

namespace GerenciadorDeBiblioteca.NovaPasta.InputModel
{
    public class LivroInputModel
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro FromEntity() => new(Titulo, Autor, ISBN, AnoPublicacao);
    }
}
