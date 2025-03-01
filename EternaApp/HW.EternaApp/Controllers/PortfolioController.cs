using HW.EternaApp.DATA;
using HW.EternaApp.ViewModels.PortfolioFolder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW.EternaApp.Controllers
{
    public class PortfolioController (EternaAppContext _appContext): Controller
    {
        public IActionResult Index()
        {
            PortfolioVm portfolioVm = new PortfolioVm()
            {
                Projects = _appContext.Projects
                .Include(p => p.ProjectImages).ToList(),
                Categories = _appContext.Categories.ToList()
            };
            return View(portfolioVm);
        }
        public IActionResult Detail (int? id)
        {
            if (id is null)
            {
                return Content("Id cannot be null");
            }
            var project = _appContext.Projects.Include(p=>p.ProjectImages).Include(p=>p.Category).FirstOrDefault(p=>p.Id==id);
            if (project == null)
            {
                return Content("Project is null");
            }
            return View(project);   
        }
    }
}
