using PlatformService.Models.Common;

namespace PlatformService.Models.Entities
{
    public class Platform : EntityBase
    {
        public Platform(
            string name, 
            string publisher, 
            string cost)
        {
            Name = name;
            Publisher = publisher;
            Cost = cost;
        }

        protected Platform()
        {
            
        }

        public string Name { get; private set; } 
        public string Publisher { get; private set; }
        public string Cost { get; private set; }
    }
}
