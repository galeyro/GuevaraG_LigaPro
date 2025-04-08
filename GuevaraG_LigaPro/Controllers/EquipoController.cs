using GuevaraG_LigaPro.Models;
using GuevaraG_LigaPro.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace GuevaraG_LigaPro.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult List()
        {
            EquipoRepository repositorio = new EquipoRepository();
            var equipos = repositorio.DevuelveListadoEquipos();

            return View(equipos);
        }
    }
}
