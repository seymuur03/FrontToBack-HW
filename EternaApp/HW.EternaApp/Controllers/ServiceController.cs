using HW.EternaApp.DATA;
using HW.EternaApp.ViewModels.ServiceFolder;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HW.EternaApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly EternaAppContext _appContext;
        public ServiceController(EternaAppContext appContext)
        {
            _appContext = appContext;
        }
        public IActionResult Index()
        {
            ServiceVm serviceVm = new ServiceVm()
            {
                Services = _appContext.Services.ToList(),
                Skills = _appContext.Skills.ToList()
            };
            return View(serviceVm);
        }
    }
}
