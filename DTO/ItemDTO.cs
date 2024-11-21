namespace Estoque.DTO
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ItemDTO(int id, string name)
        {
             Id = id;
             Name = name;
        }
        
    }
}
