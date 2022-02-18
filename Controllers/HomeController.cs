using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL3;
using System.Threading.Tasks;

namespace WebApplicationHomeWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("getBooks")]
        public List<Game> GetAllBooks(int bookId)
        {
            return new List<Game>()
            {
                new Game()
                {
                    Id = new Random().Next(100),
                    Name = "The whitcher 3. Whild Hung",
                    Janr = "Приключение"
                },
                new Game()
                {
                    Id = new Random().Next(100),
                    Name = "PUBG",
                    Janr = "Батл рояль"
                }
            };
        }
    }
}
