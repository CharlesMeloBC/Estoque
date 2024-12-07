namespace Estoque.Models
{
    public class ItemModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;

        public bool IsDeleted { get; private set; } 

        public void Disable () 
        { 
            IsDeleted = true;
        }  

        public ItemModel(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Nome não pode ser vazio.", nameof(name));

            Name = name; 
        }

        public string GetName() => Name;

        public void UpdateName(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new ArgumentNullException(nameof(newName), "Nome não pode ser vazio.");

            Name = newName;
        }
    }
}
