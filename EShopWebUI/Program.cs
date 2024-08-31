using BusinessLayer.Concrete; // CategoryRepository ve diðer gerekli using direktifleri
using Microsoft.EntityFrameworkCore;
using EntityLayer.Entities;
using DataAccessLayer.Context;
using DataAccessLayer.Abstract.EntityRepository;
using DataAccessLayer.Concrete;
using BusinessLayer.Abstract;
using System.Reflection;

namespace EShopWebUI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			// Add DbContext to the service container
			builder.Services.AddDbContext<DataContext>(options =>
			{
				options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
			});
			builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

			builder.Services.AddScoped<ICategoryService, CategoryService>();
            builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();

            builder.Services.AddScoped<IProductService, ProductService>();
			builder.Services.AddScoped<IProductRepository, ProductRepository>();

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

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
