using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // GET: api/Student
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            return await Task.FromResult(new string[] { "value1", "value2" });
        }
        // GET: api/Student/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<string> Get(int id)
        {
            return await Task.FromResult("value");
        }
        // POST: api/Student
        [HttpPost]
        public async Task Post([FromBody] string value)
        {
            await Task.CompletedTask;
        }
        // PUT: api/Student/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] string value)
        {
            await Task.CompletedTask;
        }
        // DELETE: api/Student/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await Task.CompletedTask;
        }
    }
}