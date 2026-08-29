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
                new EventoHistorico
                {
                    Ano = "1541",
                    Titulo = "Fundação de Santiago",
                    ImagemUrl = "/images/historia/1541-fundacao-santiago.jpg",
                    Descricao = "Santiago foi fundada em 1541 por Pedro de Valdivia, durante o processo de colonização espanhola. A cidade foi construída no vale do rio Mapocho e, com o tempo, tornou-se um dos principais centros políticos, econômicos e culturais do Chile."
                },
                new EventoHistorico
                {
                    Ano = "1810",
                    Titulo = "Início da Independência",
                    ImagemUrl = "/images/historia/1810-inicio-independencia.jpg",
                    Descricao = "O processo de independência começou em 1810, quando foi formada a Primeira Junta de Governo. O movimento surgiu em meio à crise da monarquia espanhola e marcou o início da luta dos chilenos por maior autonomia e, posteriormente, pela independência."
                },
                new EventoHistorico
                {
                    Ano = "1818",
                    Titulo = "Independência do Chile",
                    ImagemUrl = "/images/historia/1818-independencia.jpg",
                    Descricao = "Em 12 de fevereiro de 1818, o Chile declarou oficialmente sua independência da Espanha. A separação foi resultado de anos de conflitos entre os grupos que apoiavam a independência e as forças espanholas, com nomes importantes como Bernardo O'Higgins e José de San Martín."
                },
                new EventoHistorico
                {
                    Ano = "1879–1884",
                    Titulo = "Guerra do Pacífico",
                    ImagemUrl = "/images/historia/1879-guerra-pacifico.jpg",
                    Descricao = "A Guerra do Pacífico envolveu Chile, Peru e Bolívia e teve como uma de suas principais causas a disputa por territórios ricos em recursos naturais, especialmente o salitre. Após a guerra, o Chile ampliou seu território para o norte e passou a controlar importantes áreas de mineração."
                },
                new EventoHistorico
                {
                    Ano = "Século XX",
                    Titulo = "Transformações políticas e sociais",
                    ImagemUrl = "/images/historia/seculo-xx.jpg",
                    Descricao = "Durante o século XX, o Chile passou por grandes transformações políticas e sociais, com diferentes governos, reformas econômicas e mudanças nas condições de vida da população. Em 1973, ocorreu um golpe militar que iniciou uma ditadura, encerrada em 1990 com o retorno à democracia."
                },
                new EventoHistorico
                {
                    Ano = "Atualidade",
                    Titulo = "Chile hoje",
                    ImagemUrl = "/images/historia/atualidade.jpg",
                    Descricao = "Atualmente, o Chile é uma república democrática e possui uma das economias mais desenvolvidas da América Latina. O país se destaca por sua diversidade cultural e por paisagens como o deserto do Atacama, a Cordilheira dos Andes e a Patagônia."
                }
            };

            var trajes = new List<TrajeTradicional>
            {
                new TrajeTradicional
                {
                    Nome = "Huaso",
                    ImagemUrl = "/images/roupas/huaso.png",
                    Descricao = "O huaso é o tradicional homem do campo chileno, símbolo da zona central do país. Seu traje inclui a manta (poncho listrado), chamanto ou faixa, chaparreras de couro e o chapéu de abas largas, usado tanto no trabalho no campo quanto em festividades como o rodeio."
                },
                new TrajeTradicional
                {
                    Nome = "Chupalla",
                    ImagemUrl = "/images/roupas/chupalla.png",
                    Descricao = "A chupalla é o chapéu tradicional chileno, feito de palha ou fibra vegetal trançada. É um dos símbolos mais reconhecíveis da cultura camponesa do Chile, usado por huasos e trabalhadores rurais como proteção contra o sol."
                },
                new TrajeTradicional
                {
                    Nome = "China",
                    ImagemUrl = "/images/roupas/china.png",
                    Descricao = "A \"china\" é a parceira tradicional do huaso na dança da cueca, dança nacional chilena. Seu vestido é longo e colorido, geralmente em tons de vermelho e preto, com um lenço na mão usado durante a dança para simbolizar o cortejo entre o casal."
                },
                new TrajeTradicional
                {
                    Nome = "Traje Mapuche",
                    ImagemUrl = "/images/roupas/mapuche.png",
                    Descricao = "O traje mapuche representa o povo indígena mais numeroso do Chile. É marcado por tecidos artesanais em lã, tingidos de forma natural, e por joias de prata (platería mapuche), como o trarilonko (faixa de cabeça) e colares, que carregam forte significado cultural e espiritual."
                }
            };

            ViewBag.Trajes = trajes;
            return View(eventos);
        }
    }
}