using System.ComponentModel.DataAnnotations;

namespace HW.EternaApp.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string Description { get; set; }
    }
}
