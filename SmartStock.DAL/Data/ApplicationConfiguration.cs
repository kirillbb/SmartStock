using Microsoft.Extensions.Configuration;

namespace SmartStock.DAL.Data
{
    public class ApplicationConfiguration
    {
        public string SqlConnectionString { get; set; }

        public ApplicationConfiguration()
        {
            var configBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configBuilder.AddJsonFile(path, false);

            var root = configBuilder.Build();
            var applicationSettings = root.GetSection("ConnectionStrings:DefaultConnection");
            SqlConnectionString = applicationSettings.Value;
        }
    }
}