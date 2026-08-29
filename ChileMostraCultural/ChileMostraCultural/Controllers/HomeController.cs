using Microsoft.AspNetCore.Mvc;
using ChileMostraCultural.Models;

namespace ChileMostraCultural.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PontosTuristicos()
        {
            var destinos = new List<Destino>
            {
                new Destino { Nome = "Ilha de Páscoa", Regiao = "Valparaíso", ImagemUrl = "/images/destinos/ilha-de-pascoa.jpg" },
                new Destino { Nome = "Deserto do Atacama", Regiao = "Norte Grande", ImagemUrl = "/images/destinos/deserto-atacama.png" },
                new Destino { Nome = "Santiago", Regiao = "Região Metropolitana", ImagemUrl = "/images/destinos/santiago-card.jpg" },
                new Destino { Nome = "Valparaíso", Regiao = "Litoral Central", ImagemUrl = "/images/destinos/valparaiso.jpg" },
                new Destino { Nome = "Valle Nevado", Regiao = "Região Metropolitana", ImagemUrl = "/images/destinos/valle-nevado.jpg" },
                new Destino { Nome = "Torres del Paine", Regiao = "Patagônia Chilena", ImagemUrl = "/images/destinos/torres-del-paine.jpg" }
            };

            return View(destinos);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}