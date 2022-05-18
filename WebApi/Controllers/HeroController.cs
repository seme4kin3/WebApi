using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/hero")]
    public class HeroController : ControllerBase
    {
        
        private List<Hero> hero = new List<Hero>()
        {
            new() {Id = 1, Name = "Kratos", Level = 25},
            new() {Id = 2, Name = "Mike", Level = 15},
            new() {Id = 3, Name = "John", Level = 0},
        };

        private readonly ILogger<Controllers.HeroController> _logger;

        public HeroController(ILogger<Controllers.HeroController> logger)
        { 
            _logger = logger;
        }
        
        [HttpGet]
        public IEnumerable<Hero> Get()
        {
            return hero;
        }
        
        [HttpGet("{id}")]
        public Hero GetById(int id)
        {
            Hero? hero = this.hero.FirstOrDefault(h => h.Id == id);
             
            return hero;
        }
        
    }
}