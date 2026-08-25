using Microsoft.AspNetCore.Mvc;
using ChileMostraCultural.Models;

namespace ChileMostraCultural.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            var itens = new List<ItemGaleria>
            {
                new ItemGaleria { Legenda = "Torres del Paine" },
                new ItemGaleria { Legenda = "Deserto do Atacama" },
                new ItemGaleria { Legenda = "Moais da Ilha de Páscoa" },
                new ItemGaleria { Legenda = "Valparaíso" },
                new ItemGaleria { Legenda = "Vulcão Villarrica" },
                new ItemGaleria { Legenda = "Santiago" }
            };

            return View(itens);
        }
    }
}
