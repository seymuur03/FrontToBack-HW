using HW.MentorApp.DATA;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HW.MentorApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly MentorAppContext _appContext;
        public CourseController(MentorAppContext appContext)
        {
            _appContext = appContext;
        }
        public IActionResult Index()
        {
            var courses = _appContext.Courses.Include(c => c.Category).ToList();
            return View(courses);
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var course = _appContext.Courses.Include(c=>c.Category).SingleOrDefault(x=>x.Id==id);  
            
            if (course == null)
            {
                return NotFound();  
            }
            return View(course);     
        }
    }
}
