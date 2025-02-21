
using HW.MentorApp.DATA;
using HW.MentorApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HW.MentorApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MentorAppContext _appContext;
        public HomeController(MentorAppContext appContext)
        {
            _appContext = appContext;
        }

        public IActionResult Index()
        {
            var _picture = _appContext.Pictures.FirstOrDefault();
            var whyus = _appContext.WhyUs.ToList();
            var course = _appContext.Courses.Include(c => c.Category).ToList();
            HomeVm homeVm = new HomeVm()
            {
                Pictures = _picture,
                WhyUs = whyus,
                Courses = course
            };
            return View(homeVm);
        }

       
    }
}
