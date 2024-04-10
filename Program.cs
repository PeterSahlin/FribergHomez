
using FribergHomez.Data;
using Microsoft.EntityFrameworkCore;

namespace FribergHomez
{
    //All
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FribergHomez;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IFirm, FirmRepository>();
            builder.Services.AddScoped<ISaleObject, SaleObjectRepository>();
            builder.Services.AddScoped<IRealEstateAgent, RealEstateAgentRepository>();
            builder.Services.AddScoped<IMunicipality, MunicipalityRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

        }
    }
}
