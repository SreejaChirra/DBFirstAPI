using Microsoft.EntityFrameworkCore;
using DBFirstAPI.Models;
using DBFirstAPI.PersonRepo;

namespace DBFirstAPI
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
            builder.Services.AddDbContext<API_DemoContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));

            builder.Services.AddTransient<API_DemoContext>();
            builder.Services.AddTransient<IPersonRepo, class2>();
            //builder.Services.AddMvc(options =>
            //{
            //    options.SuppressAsyncSuffixInActionNames = false;
            //});



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}