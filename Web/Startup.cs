using Xml.Options;
using Xml.Repositories;
using Xml.Repositories.Offers;
using Xml.Services.Offers;

namespace MVC;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection service)
    {
        service.AddControllersWithViews(_ => _.EnableEndpointRouting = false);
        service.AddSingleton<IOffersService, OffersService>();
        service.AddSingleton<IOffersContext, OffersContext>();
        service.AddSingleton<ApplicationContext>();
        service.Configure<XmlReadFileOptions>(_configuration.GetSection("XmlReadFileSettings"));
        service.Configure<DbConnectionOptions>(_configuration.GetSection("DbConnectionSettings"));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

        app.UseStaticFiles();
        app.UseRouting();
        app.UseMvc();
    }
}