using System.Collections.Generic;
using System.Linq;

namespace GuevaraG_LigaPro.Models.Repositories
{
    public class EquipoRepository
    {
        // Lista estática para mantener los datos en memoria
        // Datos quemados a 14/04/2025
        private static List<Equipo> equipos = new List<Equipo>
        {
            new Equipo
            {
                Id = 1,
                Nombre = "Independiente",
                PartidosJugados = 8,
                PartidosGanados = 4,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1
            },
            new Equipo
            {
                Id = 2,
                Nombre = "Cuniburo",
                PartidosJugados = 8,
                PartidosGanados = 4,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1
            },
            new Equipo
            {
                Id = 3,
                Nombre = "Barcelona SC",
                PartidosJugados = 6,
                PartidosGanados = 5,
                PartidosEmpatados = 0,
                PartidosPerdidos = 1
            },
            new Equipo
            {
                Id = 4,
                Nombre = "U. Católica",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1
            },
            new Equipo
            {
                Id = 5,
                Nombre = "Mushuc Runa",
                PartidosJugados = 8,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2
            },
            new Equipo
            {
                Id = 6,
                Nombre = "Libertad FC",
                PartidosJugados = 8,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2
            },
            new Equipo
            {
                Id = 7,
                Nombre = "LDU Quito",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 2,
                PartidosPerdidos = 2
            },
            new Equipo
            {
                Id = 8,
                Nombre = "Dep. Cuenca",
                PartidosJugados = 8,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 4
            },
            new Equipo
            {
                Id = 9,
                Nombre = "Orense",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 3
            },
            new Equipo
            {
                Id = 10,
                Nombre = "Aucas",
                PartidosJugados = 7,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2
            },
            new Equipo
            {
                Id = 11,
                Nombre = "Macará",
                PartidosJugados = 8,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3
            },
            new Equipo
            {
                Id = 12,
                Nombre = "Manta",
                PartidosJugados = 8,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3
            },
            new Equipo
            {
                Id = 13,
                Nombre = "Emelec",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 4,
                PartidosPerdidos = 3
            },
            new Equipo
            {
                Id = 14,
                Nombre = "Técnico Universitario",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4
            },
            new Equipo
            {
                Id = 15,
                Nombre = "Delfín",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4
            },
            new Equipo
            {
                Id = 16,
                Nombre = "El Nacional",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 2,
                PartidosPerdidos = 5
            }
        };

        // Constructor estático para inicializar los puntos de cada equipo
        static EquipoRepository()
        {
            foreach (var equipo in equipos)
            {
                equipo.CalcularPuntos();
            }
        }

        // Método para devolver la lista de equipos
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            return equipos;
        }

        // Método para actualizar un equipo existente
        public void ActualizarEquipo(Equipo equipo)
        {
            var equipoExistente = equipos.FirstOrDefault(e => e.Id == equipo.Id);
            if (equipoExistente != null)
            {
                equipoExistente.PartidosJugados = equipo.PartidosJugados;
                equipoExistente.PartidosGanados = equipo.PartidosGanados;
                equipoExistente.PartidosEmpatados = equipo.PartidosEmpatados;
                equipoExistente.PartidosPerdidos = equipo.PartidosPerdidos;
                equipoExistente.CalcularPuntos();
            }
        }
    }
}
