namespace HW.MentorApp.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PricingService> PricingServices { get; set; }
    }

}
