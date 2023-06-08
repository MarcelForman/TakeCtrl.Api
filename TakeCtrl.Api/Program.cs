
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using TakeCtrl.Api.Data;
using TakeCtrl.Api.Repositories;
using TakeCtrl.Api.Repositories.Contracts;

namespace TakeCtrl.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContextPool<TakeCtrlDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("TakeCtrlConnection")));

            builder.Services.AddScoped<IServerRepository, ServerRepository>();                
            builder.Services.AddScoped<IUserRepository, UserRepository>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            //app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}