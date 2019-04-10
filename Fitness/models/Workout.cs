

namespace Fitness
{
    public class Workout 
    {
        // public string id { get; set; }
        // public string name { get; set; }
        private readonly IWorkOutInterface Iface;
        public string name { get; set; }
        public string description { get; set; }
        public string id { get; set; }
        public string URL { get; set; }

        public Workout (IWorkOutInterface iface)
        {
            Iface = iface;
            name = iface.GetName();
            description = iface.GetDescription();
            id = iface.GetId();
            URL = iface.GetVideoURL();
        }
        
    }

}