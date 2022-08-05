namespace Northwind.Empty.Web;

public class Startup
{
    public void ConfigureServices(IServiceCollection serviceCollection)
    {
        serviceCollection.AddNorthwindContext();
        serviceCollection.AddRazorPages();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        if (!env.IsDevelopment())
        {
            app.UseHsts();
        }

        app.UseDefaultFiles();
        app.UseStaticFiles();
       
        app.UseRouting();
        app.UseHttpsRedirection();
        app.UseEndpoints(endpoint =>
        {
            endpoint.MapRazorPages();
            endpoint.MapGet("/hello", () => "Hello World!"); 

        });
    }
}

