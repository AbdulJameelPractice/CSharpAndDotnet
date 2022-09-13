var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");

app.Run();

Console.WriteLine("This will execute after the server is shutdown AbdUL");