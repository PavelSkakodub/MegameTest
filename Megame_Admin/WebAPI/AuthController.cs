using Megame_Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Megame_Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class Auth : ControllerBase
    {
        [HttpGet]
        public async Task<JsonResult> Get() //получаем список всех никнеймов
        {
            using DbContext context = new DbContext();
            var result = await context.Players
                .Select(x => x.Username)
                .ToListAsync();
            return new JsonResult(result);
        }

        [HttpGet("{token}")]
        public async Task<JsonResult> Get(string token) //получение инфы по игроку
        {
            using DbContext context = new DbContext();
            var player = await context.Players
                .Include(x => x.PlayerMessages)                
                .FirstOrDefaultAsync(x => x.Token == token);
            return new JsonResult(player);
        }
        
 
        [HttpPost]
        public async Task<string> Post([FromBody] Player player) //регистрация игрока
        {
            using DbContext context = new DbContext();
            //проверка по токену что игрок уже зарегестрирован
            var gamer = await context.Players.AnyAsync(x => x.Token == player.Token);
            //если новый - регаем
            if (!gamer)
            {
                await context.Players.AddAsync(new Player()
                {
                    Username = player.Username,
                    Token = player.Token,
                    PlayerMessages = new List<PlayerMessage>()
                });
                await context.SaveChangesAsync();
                return "Completed";
            }            
            else return "Already registered";
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
