using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public class Startup
{
    public IConfiguration Configuration { get; }

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddMvc();

        // Add any other services you need here
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "CompaniesIndex1",
                pattern: "Companies/Index1",
                defaults: new { controller = "Companies", action = "Index" });

            endpoints.MapControllerRoute(
                name: "CompaniesCreate",
                pattern: "Companies/Create",
                defaults: new { controller = "Companies", action = "Create" });

            endpoints.MapControllerRoute(
                name: "CompaniesEdit",
                pattern: "Companies/Edit",
                defaults: new { controller = "Companies", action = "Edit" });

            endpoints.MapControllerRoute(
                name: "CompaniesDelete",
                pattern: "Companies/Delete",
                defaults: new { controller = "Companies", action = "Delete" });

            endpoints.MapControllerRoute(
                name: "CompaniesDetails",
                pattern: "Companies/Details",
                defaults: new { controller = "Companies", action = "Details" });

            // I can add any other routes I need here

            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        });

    }
}
