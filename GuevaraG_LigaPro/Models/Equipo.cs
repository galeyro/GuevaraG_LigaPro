using System.ComponentModel.DataAnnotations;

namespace GuevaraG_LigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }
        [Range(0,20)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        public int TotalPuntos { get; set; }

        //Metodo para calcular los puntos
        public void CalcularPuntos()
        {
            TotalPuntos = (PartidosGanados * 3) + PartidosEmpatados;
        }
    }
}
