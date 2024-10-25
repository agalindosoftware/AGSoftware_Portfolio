namespace ServerManagement.Models
{
    public class ServicesRepository
    {
        private static List<string> services = new List<string>()
        {
            "Design 1",
            "Development 2",
            "implement 3"

        };
        public static List<string> GetServices() => services;
    }
}
