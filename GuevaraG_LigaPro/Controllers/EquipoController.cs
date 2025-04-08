using GuevaraG_LigaPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuevaraG_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult List()
        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                Id = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosEmpatados = 0,
                PartidosPerdidos = 0,
                TotalPuntos = 30
            };

            Equipo bcs = new Equipo
            {
                Id = 2,
                Nombre = "BCS",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosEmpatados = 0,
                PartidosPerdidos = 9,
                TotalPuntos = 3
            };

            equipos.Add(ldu);
            equipos.Add(bcs);

            return View(equipos);
        }
    }
}
