using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VehicleTracking.DataModels;
using VehicleTracking.Repositories.Implementations;
using VehicleTracking.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<Context>(options =>options.UseSqlServer());
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<ITrackingCurrentRepository, TrackingCurrentRepository>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();