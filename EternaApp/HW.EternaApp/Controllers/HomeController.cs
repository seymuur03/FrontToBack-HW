
using HW.EternaApp.DATA;
using HW.EternaApp.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW.EternaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly EternaAppContext _appContext;
        public HomeController(EternaAppContext appContext)
        {
            _appContext = appContext;
        }

        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm()
            {
                Sliders = _appContext.Sliders.OrderBy(s=>s.Order).ToList(),
                Features = _appContext.Features.ToList(),
                Services = _appContext.Services.ToList(),
                Clients = _appContext.Clients.ToList(),
                ClientsImages = _appContext.ClientsImages.ToList()
            };
            return View(homeVm);
        }

        
    }
}
