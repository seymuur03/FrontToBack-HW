using HW.EternaApp.Models;

namespace HW.EternaApp.ViewModels.BlogFolder
{
    public class BlogVm
    {
        public List<Blog> Blogs { get; set; }
        public List<BlogCategory> BlogCategories{ get; set; }
        public List<Blog> RecentBlogs { get; set; }

    }
}
