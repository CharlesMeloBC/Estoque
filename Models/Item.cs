namespace Estoque.Models
{
    class Item
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;


        public Item(string name)
        {
            string Name = name;
        }

        public string GetName () { return Name; }

        public void UpdateName (string newName) 
        {
            if (string.IsNullOrWhiteSpace(newName))
            throw new ArgumentNullException("precisa preencher os campos");
            Name = newName;
        }
    
    }

       
}
