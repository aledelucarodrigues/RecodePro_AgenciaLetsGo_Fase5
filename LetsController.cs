using Letsgo.Data;
using Letsgo.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lets.Controllers{

[ApiController]
[Route("api/[controller]")]
    public class LetsController : ControllerBase{
        
        private readonly DataContext _dataContext;

        public LetsController(DataContext dataContext){
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LetsTodos>>> GetLets()
        { return await _dataContext.Letsgo.ToListAsync();

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LetsTodos>> GetLetsById(int id)
        {
            var lets = await _dataContext.Letsgo.FindAsync(id);
            if(lets == null){
                return NotFound();
            }
            return Ok(lets);
        }
    }
}

        
    