namespace PlatformService.Models.Dtos
{
    public class PlatformDetails 
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Publisher { get; private set; } = string.Empty;
        public string Cost { get; private set; } = string.Empty;
    }
}
