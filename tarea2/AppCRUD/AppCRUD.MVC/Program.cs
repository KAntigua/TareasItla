using AppCRUD.MVC.Data;
using Microsoft.EntityFrameworkCore;




            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<appDBcontext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSQL"));

});

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Empleado}/{action=Lista}/{id?}");

            app.Run();
        
    
