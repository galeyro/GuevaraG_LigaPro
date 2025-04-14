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
            var equipos = repositorio.DevuelveListadoEquipos()
                                      .OrderByDescending(e => e.TotalPuntos);
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

        [HttpPost]
        public IActionResult EditarEquipo(Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                EquipoRepository repositorio = new EquipoRepository();
                repositorio.ActualizarEquipo(equipo); // Actualiza el equipo en la lista estática

                return RedirectToAction("List"); // Redirige a la lista de equipos
            }

            return View(equipo); // Si hay errores, vuelve a mostrar la vista de edición
        }




    }
}
