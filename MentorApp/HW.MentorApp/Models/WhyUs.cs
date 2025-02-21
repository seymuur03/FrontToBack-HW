using System.ComponentModel.DataAnnotations;

namespace HW.MentorApp.Models
{
    public class WhyUs
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Icon { get; set; }
        public string Description { get; set; }
    }
}
