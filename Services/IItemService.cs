using Estoque.DTO;

namespace Estoque.Services
{
    public interface IItemService
    {
        IEnumerable<ItemDTO> GetAll();
        ItemDTO Create(ItemDTO itemDTO);
        Task<bool> Delete(int id);
    }
}
