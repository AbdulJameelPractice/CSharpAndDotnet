using Northwind.Empty.Web;

Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(builder =>
{
    builder.UseStartup<Startup>();
}).Build().Run();

Console.WriteLine("End of run");


