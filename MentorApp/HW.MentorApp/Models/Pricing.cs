using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW.MentorApp.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsAdvanced { get; set; }
        public List<PricingService> PricingServices { get; set; }
    }
}
