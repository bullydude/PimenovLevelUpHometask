using CoffeeStore.DataAccess;
using CoffeeStore.DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace CoffeeStore.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<CoffeeStoreContext>(options =>
                options.UseSqlServer("Server=localhost,1433;Database=CoffeeStore;User Id=sa;Password=hydadm;TrustServerCertificate=True"));
            builder.Services.AddScoped<IProductsRepository, ProductsRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapControllers();

            app.Run();
        }
    }
}