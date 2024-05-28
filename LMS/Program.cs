using Microsoft.EntityFrameworkCore;
using LMS.Data;
using LMS.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ILibrarianService, LibrarianServiceImp>();
var connectionString = builder.Configuration.GetConnectionString("MyConnection");
builder.Services.AddDbContext<EntityDbContext>(options =>
{
    options.UseSqlServer(connectionString);

});

var app = builder.Build();



app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();
