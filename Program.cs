var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configure DefaultFiles middleware to serve "index.html" by default
app.UseDefaultFiles(new DefaultFilesOptions
{
    DefaultFileNames = new List<string> { "index.html" }
});

app.UseStaticFiles(); // This middleware serves files from wwwroot
// app.MapGet("/", () => "Hello World!");

app.Run();
