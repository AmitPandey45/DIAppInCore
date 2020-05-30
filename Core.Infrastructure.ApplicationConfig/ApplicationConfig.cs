namespace Core.Infrastructure.ApplicationConfig
{
    public class ApplicationConfig
    {
        //public static IConfigurationRoot Configuration;
        //public string Read(string configKey)
        //{
        //    return ConfigurationManager.AppSettings.Get(configKey);
        //}

        //public string Read(string configKey, string defaultValue)
        //{
        //    string configValue = ConfigurationManager.AppSettings.Get(configKey);
        //    if (configValue != null)
        //    {
        //        return configValue;
        //    }
        //    else
        //    {
        //        return defaultValue;
        //    }
        //}

        //public static string GetConnectionString()
        //{
        //    var AppName = new ConfigurationBuilder().Add("appsettings.json").Build().GetSection("AppSettings")["APP_Name"];
        //    var builder = new ConfigurationBuilder()
        //           .SetBasePath(Directory.GetCurrentDirectory())
        //           .AddJsonFile("appsettings.json");

        //    Configuration = builder.Build();
        //    var connectionString = Configuration["ConnectionStrings:YourConnectionString"];

        //}
        //public void Startup(IHostingEnvironment env)
        //{
        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(env.ContentRootPath)
        //        .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

        //    Configuration = builder.Build();
        //}
    }
}
