using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private List<Proyecto> ObtenerProyectos() {
            return new List<Proyecto>() { new Proyecto 
                {
                    Titulo = "Amazon",
                    Descripcion = "E-conmerce realizado en ASP.NET core",
                    Link = "https://amazon.com",
                    ImagenURL = "/images/amazon.png"
                }, 
                new Proyecto 
                {
                    Titulo = "New York Times",
                    Descripcion = "Pagina de noticias en React",
                    Link = "https://nytimes.com",
                    ImagenURL = "/images/nytimes.png"
                },
                new Proyecto
                {
                    Titulo = "Reddit",
                    Descripcion = "Red social de noticias y contenido",
                    Link = "https://reddit.com",
                    ImagenURL = "/images/reddit.png"
                },
                new Proyecto 
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda en linea para comprar videojuegos",
                    Link = "https://store.steampowered.com",
                    ImagenURL = "/images/steam.png"
                },
            };
        }
    }
}
