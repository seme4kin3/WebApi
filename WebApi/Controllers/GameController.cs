using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Models;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("api/game")]
    public class GameController: ControllerBase

    {
        private List<Game> game = new List<Game>()
        {
            new() {Id = 1, Price = 4500, Title = "God of War"},
            new() {Id = 2,Price = 2500,Title = "Need for Speed"},
            new () {Id = 3,Price = 1200,Title = "CS:Go"}
        };

        private readonly ILogger<GameController> _logger;

        public GameController(ILogger<GameController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return game;
        }
        
        [HttpGet("{id}")]
        public Game GetById(int id)
        {
            Game? game = this.game.FirstOrDefault(g => g.Id == id);
             
            return game;
        }
    }
}