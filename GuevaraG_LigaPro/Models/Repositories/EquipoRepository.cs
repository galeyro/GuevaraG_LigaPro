using Microsoft.AspNetCore.Mvc;

namespace GuevaraG_LigaPro.Models.Repositories
{
    public class EquipoRepository
    {
        public IEnumerable<Equipo> DevuelveListadoEquipos()
        {
            //Datos de equipos quemados a fecha 13/04/2025
            List<Equipo> equipos = new List<Equipo>();

            Equipo cun = new Equipo
            {
                Id = 1,
                Nombre = "Cuniburo",
                PartidosJugados = 8,
                PartidosGanados = 4,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
            };
            cun.CalcularPuntos();

            Equipo bsc = new Equipo
            {
                Id = 2,
                Nombre = "Barcelona SC",
                PartidosJugados = 6,
                PartidosGanados = 5,
                PartidosEmpatados = 0,
                PartidosPerdidos = 1,
            };
            bsc.CalcularPuntos();

            Equipo cat = new Equipo
            {
                Id = 3,
                Nombre = "U. Católica",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
            };
            cat.CalcularPuntos();

            Equipo ind = new Equipo
            {
                Id = 4,
                Nombre = "Independiente",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 1,
            };
            ind.CalcularPuntos();

            Equipo lib = new Equipo
            {
                Id = 5,
                Nombre = "Libertad FC",
                PartidosJugados = 8,
                PartidosGanados = 3,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
            };
            lib.CalcularPuntos();

            Equipo ldu = new Equipo
            {
                Id = 6,
                Nombre = "LDU Quito",
                PartidosJugados = 6,
                PartidosGanados = 3,
                PartidosEmpatados = 2,
                PartidosPerdidos = 1,
            };
            ldu.CalcularPuntos();

            Equipo cue = new Equipo
            {
                Id = 7,
                Nombre = "Dep. Cuenca",
                PartidosJugados = 8,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 4,
            };
            cue.CalcularPuntos();

            Equipo ore = new Equipo
            {
                Id = 8,
                Nombre = "Orense",
                PartidosJugados = 7,
                PartidosGanados = 3,
                PartidosEmpatados = 1,
                PartidosPerdidos = 3,
            };
            ore.CalcularPuntos();

            Equipo mus = new Equipo
            {
                Id = 9,
                Nombre = "Mushuc Runa",
                PartidosJugados = 7,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
            };
            mus.CalcularPuntos();

            Equipo auc = new Equipo
            {
                Id = 10,
                Nombre = "Aucas",
                PartidosJugados = 7,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 2,
            };
            auc.CalcularPuntos();

            Equipo mac = new Equipo
            {
                Id = 11,
                Nombre = "Macará",
                PartidosJugados = 8,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3,
            };
            mac.CalcularPuntos();

            Equipo man = new Equipo
            {
                Id = 12,
                Nombre = "Manta",
                PartidosJugados = 8,
                PartidosGanados = 2,
                PartidosEmpatados = 3,
                PartidosPerdidos = 3,
            };
            man.CalcularPuntos();

            Equipo eme = new Equipo
            {
                Id = 13,
                Nombre = "Emelec",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 4,
                PartidosPerdidos = 3,
            };
            eme.CalcularPuntos();

            Equipo tec = new Equipo
            {
                Id = 14,
                Nombre = "Técnico Univ.",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4,
            };
            tec.CalcularPuntos();

            Equipo del = new Equipo
            {
                Id = 15,
                Nombre = "Delfín",
                PartidosJugados = 8,
                PartidosGanados = 1,
                PartidosEmpatados = 3,
                PartidosPerdidos = 4,
            };
            del.CalcularPuntos();

            Equipo nac = new Equipo
            {
                Id = 16,
                Nombre = "El Nacional",
                PartidosJugados = 7,
                PartidosGanados = 1,
                PartidosEmpatados = 2,
                PartidosPerdidos = 4,
            };
            nac.CalcularPuntos();

            // Agregar equipos a la lista
            equipos.Add(cun);
            equipos.Add(bsc);
            equipos.Add(cat);
            equipos.Add(ind);
            equipos.Add(lib);
            equipos.Add(ldu);
            equipos.Add(cue);
            equipos.Add(ore);
            equipos.Add(mus);
            equipos.Add(auc);
            equipos.Add(mac);
            equipos.Add(man);
            equipos.Add(eme);
            equipos.Add(tec);
            equipos.Add(del);
            equipos.Add(nac);

            return equipos;
        }
    }
}