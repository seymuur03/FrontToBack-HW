using System.ComponentModel.DataAnnotations;

namespace HW.MentorApp.Models
{
    public class Picture
    {
        [Required]
        public string Img { get; set; }
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public string Button { get; set; }
        
    }
}
