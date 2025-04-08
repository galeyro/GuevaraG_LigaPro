using System.ComponentModel.DataAnnotations;

namespace GuevaraG_LigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int PartidosJugados { get; set; }
        public int PartidosGanados { get; set; }
        public int PartidosEmpatados { get; set; }
        public int PartidosPerdidos { get; set; }
        public int TotalPuntos { get; set; }
    }
}
