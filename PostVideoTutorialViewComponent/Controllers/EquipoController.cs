using Microsoft.AspNetCore.Mvc;
using PostVideoTutorialViewComponent.Models;
using PostVideoTutorialViewComponent.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostVideoTutorialViewComponent.Controllers
{
    public class EquipoController : Controller
    {
        private RepositoryEquipos repo;
        public EquipoController(RepositoryEquipos repo) 
        {
            this.repo = repo;
        }
        public IActionResult Details( int idequipo)
        {
            Equipo equipo = this.repo.FindEquipo(idequipo);
            return View(equipo);
        }
    }
}
