using Estoque.Data;
using Estoque.DTO;
using Estoque.Models;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Services
{
    public class ItemService : IItemService
    {
        private readonly AppDbContext _context;

        public ItemService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ItemDTO> GetAll()
        {
            return _context.Item
                .Select(item => new ItemDTO(item.Id, item.Name))
                .ToList();
        }

        public ItemDTO Create(ItemDTO itemDto)
        {
            var item = new ItemModel(itemDto.Name);

            _context.Item.Add(item);
            _context.SaveChanges();

            return new ItemDTO(item.Id, item.Name);
        }

        public async Task<bool> Delete (int id)
        {
            var item = await _context.Item.FindAsync(id);
            if (item == null)
                return false;

            item.Disable();
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
