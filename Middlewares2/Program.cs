using Middlewares2.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.UseMiddleware<RequestLoggingMiddleware>();
//app.MapGet("/", () => "Hello From the Home route");
//app.MapGet("/about", () => "This is the About Page");

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapGet("/crash", () =>
{
    throw new Exception("Simulated Crash");
});
app.MapGet("/", () => "App is running fine");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
