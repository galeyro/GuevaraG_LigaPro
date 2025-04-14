using GuevaraG_LigaPro.Models;
using GuevaraG_LigaPro.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GuevaraG_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        //Acción para mostrar la lista de equipos
        public IActionResult List()
        {
            EquipoRepository repositorio = new EquipoRepository();
            var equipos = repositorio.DevuelveListadoEquipos();

            return View(equipos);
        }

        // Acción para mostrar los detalles de un equipo
        public IActionResult Details(int id)
        {
            EquipoRepository repositorio = new EquipoRepository();

            //Buscar el equipo por Id usando LINQ
            var equipo = repositorio.DevuelveListadoEquipos().FirstOrDefault(e => e.Id == id);
            //Validar si el equipo existe
            if (equipo == null)
            {
                return NotFound(); //Error 404
            }

            return View(equipo);
        }

        //Accion editar equipo
        public IActionResult EditarEquipo(int id)
        {
            EquipoRepository repositorio = new EquipoRepository();
            //Buscar el equipo por Id usando LINQ
            var equipo = repositorio.DevuelveListadoEquipos().FirstOrDefault(e => e.Id == id);
            //Validar si el equipo existe
            if (equipo == null)
            {
                return NotFound(); //Error 404
            }
            return View(equipo);
        }

        [HttpPost] //Acción del controlador para ejecutar en solicitud HTTP tipo POST
        public IActionResult EditarEquipo(Equipo equipo)
        {
            if (ModelState.IsValid) //Valida si cumple con las reglas del modelo
            {
                // Aquí puedes actualizar los datos en el repositorio o base de datos
                EquipoRepository repositorio = new EquipoRepository();
                var equipos = repositorio.DevuelveListadoEquipos().ToList();
                var equipoExistente = equipos.FirstOrDefault(e => e.Id == equipo.Id);

                if (equipoExistente != null)
                {
                    equipoExistente.PartidosJugados = equipo.PartidosJugados;
                    equipoExistente.PartidosGanados = equipo.PartidosGanados;
                    equipoExistente.PartidosEmpatados = equipo.PartidosEmpatados;
                    equipoExistente.PartidosPerdidos = equipo.PartidosPerdidos;
                    equipoExistente.CalcularPuntos(); // Recalcular los puntos
                }
                //Al guardar cambios, redirige al usuario de vuelta a la lista de equipos
                return RedirectToAction("List");
            }
            
            //Si los datos no son válidos, volver a mostrar la vista edición
            return View(equipo);
        }

    }
}
