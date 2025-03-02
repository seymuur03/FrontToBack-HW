using HW.EternaApp.DATA;
using HW.EternaApp.ViewModels.BlogFolder;
using Microsoft.AspNetCore.Mvc;

namespace HW.EternaApp.Controllers
{
    public class BlogController(EternaAppContext _appContext) : Controller
    {
        public IActionResult Index()
        {
            BlogVm blogVm = new BlogVm()
            {
                Blogs = _appContext.Blogs.ToList(),
                RecentBlogs = _appContext.Blogs.OrderByDescending(x=>x.Id).Take(4).ToList(),
                BlogCategories = _appContext.BlogCategories.ToList()
            };
            return View(blogVm);
        }
    }
}
