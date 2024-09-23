namespace GerenciadorDeBiblioteca.Models.ViewModel
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; set; }

        public string Email { get; set; }

        public static UsuarioViewModel FromEntity(Usuario u) => new UsuarioViewModel(u.Nome, u.Email);
    }
}
