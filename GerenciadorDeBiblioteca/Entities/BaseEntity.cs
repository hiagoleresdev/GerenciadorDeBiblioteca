namespace GerenciadorDeBiblioteca.Entities
{
    public class BaseEntity
    {
        public BaseEntity() 
        {
            CreatedAt = DateTime.Now;
            IsDeleted = false;
        }

        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool IsDeleted { get; set; }

        public void SetAsDeleted()
        {
            IsDeleted = true;
        }
    }
}
