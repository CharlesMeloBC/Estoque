using Estoque.DTO;
using Estoque.Services;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            var items = _itemService.GetAll();
            return Ok(items);
        }

        [HttpPost]
        public IActionResult CreateItem([FromBody] ItemDTO itemDTO)
        {
            var item = _itemService.Create(itemDTO);
            return CreatedAtAction(nameof(GetAllItems), new {id = item.Name}, item);
        }
    }
}
