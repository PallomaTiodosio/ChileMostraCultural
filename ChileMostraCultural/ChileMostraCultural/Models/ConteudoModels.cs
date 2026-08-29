namespace ChileMostraCultural.Models
{
    public class Destino
    {
        public string Nome { get; set; } = string.Empty;
        public string Regiao { get; set; } = string.Empty;
        public string ImagemUrl { get; set; } = string.Empty;
    }

    public class EventoHistorico
    {
        public string Ano { get; set; } = string.Empty;
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string ImagemUrl { get; set; } = string.Empty;
    }

    public class ItemGaleria
    {
        public string ImagemUrl { get; set; } = string.Empty;
        public string Legenda { get; set; } = string.Empty;
    }

    public class TrajeTradicional
    {
        public string Nome { get; set; } = string.Empty;
        public string ImagemUrl { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}