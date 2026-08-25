using Microsoft.AspNetCore.Mvc;
using ChileMostraCultural.Models;

namespace ChileMostraCultural.Controllers
{
    public class HistoriaController : Controller
    {
        public IActionResult Index()
        {
            var eventos = new List<EventoHistorico>
            {
                new EventoHistorico { Ano = "1541", Titulo = "Fundação de Santiago", Descricao = "Pedro de Valdivia funda a cidade de Santiago, marco do início da colonização espanhola no Chile." },
                new EventoHistorico { Ano = "1810", Titulo = "Primeira Junta Nacional", Descricao = "Início do processo de independência com a formação do primeiro governo autônomo chileno." },
                new EventoHistorico { Ano = "1818", Titulo = "Independência do Chile", Descricao = "Proclamação oficial da independência do Chile, liderada por Bernardo O'Higgins." },
                new EventoHistorico { Ano = "1973", Titulo = "Golpe Militar", Descricao = "Um golpe de estado dá início a um longo período de regime militar no país." },
                new EventoHistorico { Ano = "1990", Titulo = "Retorno à Democracia", Descricao = "O Chile retoma o regime democrático após anos de governo militar." }
            };

            return View(eventos);
        }
    }
}
