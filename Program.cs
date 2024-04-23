using FribergHomez.Data;
using FribergHomez.Helper;
using FribergHomez.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FribergHomez
{
    //All
    public class Program
    {
        public static async Task Main(string[] args)
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
            builder.Services.AddScoped<ICategory, CategoryRepository>();

            //Cors
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });
            

            //Identity
            //builder.Services.AddIdentity<RealEstateAgent, IdentityRole<Guid>>(options => {
            //    options.SignIn.RequireConfirmedEmail = false;
            //    options.SignIn.RequireConfirmedPhoneNumber = false;
            //    options.SignIn.RequireConfirmedAccount = false;
            //})
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddDefaultTokenProviders();

            //AutomapperService
            builder.Services.AddAutoMapper(typeof(Program));

            //Identity

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            //Cors
            app.UseCors();

            app.MapControllers();


            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<ApplicationDbContext>();

               // await SeedHelper.SeedDataAsync(dbContext);

                SeedHelper seedHelper = new SeedHelper();

                await seedHelper.SeedFirmsAndAgentsAsync(dbContext); 
                await seedHelper.SeedMunicipalitiesAsync(dbContext);
                await seedHelper.SeedCategoriesAsync(dbContext);
                await seedHelper.SeedSaleObjectsAsync(dbContext);
            }
            app.Run();
        }
    }
}