using HW.EternaApp.Models;

namespace HW.EternaApp.ViewModels.Home
{
    public class HomeVm
    {
        public List<Slider> Sliders { get; set; }
        public List<Feature> Features { get; set; }
        public List<Service> Services { get; set; }
        public List<Client> Clients { get; set; }
        public List<ClientsImage> ClientsImages { get; set; }
    }
}
