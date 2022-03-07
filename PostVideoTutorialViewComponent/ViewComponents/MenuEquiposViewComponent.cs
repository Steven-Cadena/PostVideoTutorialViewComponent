using Microsoft.AspNetCore.Mvc;
using PostVideoTutorialViewComponent.Models;
using PostVideoTutorialViewComponent.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostVideoTutorialViewComponent.ViewComponents
{
    public class MenuEquiposViewComponent: ViewComponent
    {
        private RepositoryEquipos repo;
        public MenuEquiposViewComponent(RepositoryEquipos repo) 
        {
            this.repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Equipo> equipos = this.repo.GetEquipos();
            return View(equipos);
        }

    }
}
