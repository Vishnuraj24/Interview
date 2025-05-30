using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {
        List<string> fruits = new List<string>()
        {
            "Apple",
            "Banana",
            "Mango",
            "Grapes"
        };
        [HttpGet]
        public List<string> GetFruits()
        {
            return fruits;
        }
        [HttpGet("{id}")]
        public string GetFruitById(int id)
        {
            if (id >= fruits.Count) return "Id is greater than the index";
            return fruits[id];
        }
    }
}
