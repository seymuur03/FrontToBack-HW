using HW.MentorApp.Models;

namespace HW.MentorApp.ViewModels
{
    public class HomeVm
    {
        public Picture Pictures { get; set; }
        public List<WhyUs> WhyUs { get; set; }
        public List<Course> Courses { get; set; }
    }
}
