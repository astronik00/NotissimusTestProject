namespace MVC;

public static class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder.UseStartup<Startup>();
            webBuilder.ConfigureAppConfiguration(_ => _.AddJsonFile("JsonOptions/DbSettings.json"));
            webBuilder.ConfigureAppConfiguration(_ => _.AddJsonFile("JsonOptions/XmlSettings.json"));
        });
    }
}