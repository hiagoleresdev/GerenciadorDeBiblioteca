using GerenciadorDeBiblioteca.Entities;

namespace GerenciadorDeBiblioteca.Models
{
    public class Usuario : BaseEntity
    {
        public Usuario(string nome, string email)
            :base()
        {
            Nome = nome;    
            Email = email;
        }
        public string Nome { get; set; }

        public string Email { get; set; }
    }
}
