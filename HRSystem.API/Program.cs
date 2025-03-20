
using HRSystem.API.GraphQl;
using Microsoft.EntityFrameworkCore;
using HRSystem.Infrastructure.Data;
using HRSystem.Application.Services;

namespace HRSystem.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            builder.Services.AddDbContext<OrderDbContext>(options =>
                             options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IOrderService, OrderService>();

            builder.Services
           .AddGraphQLServer()
           .AddQueryType<Query>()
          .AddMutationType<Mutation>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            //if (app.Environment.IsDevelopment())
            //{
            //    app.MapOpenApi();
            //}

            //app.UseHttpsRedirection();

            //app.UseAuthorization();

            app.UseRouting();



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });


            app.Run();
        }
    }
}
