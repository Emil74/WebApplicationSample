using EmployeesWebApplication.Services;
using EmployeesWebApplication.Services.Impl;

namespace EmployeesWebApplication
{
    public class Program
    {
        public static void Main(string[] args)//1.13
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddSingleton<IEmployeesRepository, EmployeesRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();


            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id
            //    
            app.MapDefaultControllerRoute();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}