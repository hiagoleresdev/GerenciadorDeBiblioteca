namespace GerenciadorDeBiblioteca.Models.ViewModel
{
    public class ObterLivrosViewModel
    {
        public ObterLivrosViewModel(string titulo, string autor, string isbn, int anoPublicacao)
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

        public static ObterLivrosViewModel FromEntity(Livro l) => new(l.Titulo, l.Autor, l.ISBN, l.AnoPublicacao);
    }
}
