using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SimpleBackendWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        // Simple in-memory storage
        private static List<Item> _items = new List<Item>
        {
            new Item { Id = 1, Name = "Setup Visaul Studio" }
        };

        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_items);
        }

        [HttpPost]
        public IActionResult AddItem([FromBody] Item newItem){
            newItem.Id = _items.Count > 0 ? _items.Max(i => i.Id) + 1 : 1;
            _items.Add(newItem);
            return Ok(newItem);
            }

    }
}
