namespace GerenciadorDeBiblioteca.Models.ViewModel
{
    public class ObterLivrosViewModel
    {
        public ObterLivrosViewModel(string titulo, string autor, string isbn, int anoPublicacao, bool estaEmprestado)
        {
            Titulo = titulo;
            Autor = autor;  
            ISBN = isbn;
            AnoPublicacao = anoPublicacao;
            EstaEmprestado = estaEmprestado;
        }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public int AnoPublicacao { get; set; }
        public bool EstaEmprestado { get; set; }

        public static ObterLivrosViewModel FromEntity(Livro l) => new(l.Titulo, l.Autor, l.ISBN, l.AnoPublicacao, l.EstaEmprestado);
    }
}
