using Microsoft.AspNetCore.Mvc;
using ChileMostraCultural.Models;

namespace ChileMostraCultural.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var destinos = new List<Destino>
            {
                new Destino { Nome = "Torres del Paine", Regiao = "Patagônia Chilena" },
                new Destino { Nome = "Deserto do Atacama", Regiao = "Norte Grande" },
                new Destino { Nome = "Ilha de Páscoa", Regiao = "Valparaíso" },
                new Destino { Nome = "Santiago", Regiao = "Região Metropolitana" },
                new Destino { Nome = "Valparaíso", Regiao = "Litoral Central" },
                new Destino { Nome = "Vulcão Villarrica", Regiao = "Araucanía" }
            };

            return View(destinos);
        }

        public IActionResult SobreChile()
        {
            return View();
        }

        public IActionResult PontosTuristicos()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
