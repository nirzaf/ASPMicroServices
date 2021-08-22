using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: UserController/Details/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: UserController/Create
        public void Post([FromBody] string value)
        {
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Put(int id, [FromBody] string value)
        {
        }

        // GET: UserController/Delete/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}