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
    }
}
