using GerenciadorDeBiblioteca.Models;

namespace GerenciadorDeBiblioteca.NovaPasta.InputModel
{
    public class UsuarioInputModel
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public Usuario FromEntity() => new(Nome, Email);
    }
}
