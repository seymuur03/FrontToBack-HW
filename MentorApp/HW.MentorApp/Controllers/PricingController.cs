using HW.MentorApp.DATA;
using HW.MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW.MentorApp.Controllers
{
    public class PricingController : Controller
    {
        private readonly MentorAppContext _appContext;
        public PricingController(MentorAppContext appContext)
        {
            _appContext = appContext;
        }

        public IActionResult Index()
        {
            var pricing = _appContext.Pricings.Include(p=>p.PricingServices).ThenInclude(ps=>ps.Service).ToList();
            var service = _appContext.Services.ToList();
            PricingVm pricingVm = new PricingVm()
            {
                Pricings = pricing,
                Services = service
            };
            return View(pricingVm);
        }
    }
}
