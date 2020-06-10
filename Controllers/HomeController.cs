using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RusDR.Models;

namespace RusDR.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            dic.Add("lera2", new Congratulation()
            {
                Id = 1,
                Person = "Лера",
                Photo = "/files/images/lera2.jpg",
                Meme = "/files/images/lera2_meme.jpg",
                Text = new StreamReader("./wwwroot/files/text/lera2.txt").ReadToEnd(),
                Video = "/files/videos/lera2.mp4"
            });
            dic.Add("lera1", new Congratulation()
            { 
                Id = 2, 
                Person = "Лера", 
                Photo = "/files/images/lera1.jpg", 
                Meme = "/files/images/lera1_meme.jpg", 
                Text = new StreamReader("./wwwroot/files/text/lera1.txt").ReadToEnd(), 
                Video = "/files/videos/lera1.mp4"
            });
            dic.Add("andrey", new Congratulation()
            { 
                Id = 3, 
                Person = "Андрей", 
                Photo = "/files/images/andrey.jpg", 
                Meme = "/files/images/andrey_meme.jpg", 
                Text = new StreamReader("./wwwroot/files/text/andrey.txt").ReadToEnd(), 
                Video = "/files/videos/andrey.mp4"
            });
            dic.Add("nekit", new Congratulation()
            {
                Id = 4,
                Person = "Никита",
                Photo = "/files/images/nekit.jpg",
                Meme = "/files/images/nekit_meme.jpg",
                Text = new StreamReader("./wwwroot/files/text/nekit.txt").ReadToEnd(),
                Video = "/files/videos/nekit.mp4"
            });
            dic.Add("zafar", new Congratulation()
            { 
                Id = 5, 
                Person = "Зафар",
                Photo = "/files/images/zafar.jpg", 
                Meme = "/files/images/zafar_meme.png", 
                Text = new StreamReader("./wwwroot/files/text/zafar.txt").ReadToEnd(),
                Video = "/files/videos/zafar.mp4"
            });
            dic.Add("artem", new Congratulation()
            {
                Id = 6,
                Person = "Артем",
                Photo = "/files/images/artem.jpg",
                Meme = "/files/images/artem_meme.jpg",
                Text = new StreamReader("./wwwroot/files/text/artem.txt").ReadToEnd(),
                Video = "/files/videos/artem.mp4"
            });
            dic.Add("all", new Congratulation()
            { 
                Id = 7, 
                Person = "Мы все любим тебя!", 
                Photo = "/files/images/all.jpg", 
                Text = new StreamReader("./wwwroot/files/text/all.txt").ReadToEnd(),
                Video = "/files/videos/all.mp4",
                Photo2 = "files/images/all2.png"
            });
            dic["all"].PhotoSet = Directory.GetFiles("./wwwroot/files/photoset/").Select(x => x.Replace("./wwwroot", "")).ToList();
        }
        Dictionary<string, Congratulation> dic = new Dictionary<string, Congratulation>();

        public IActionResult Index()
        {
            return View(dic);
        }

        public IActionResult Congratulation(int? id)
        {
            Congratulation con = dic.Values.FirstOrDefault(x => x.Id == id);
            if (con != null)
            {
                return PartialView(con);
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
