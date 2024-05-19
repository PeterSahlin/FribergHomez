using FribergHomez.Data;
using FribergHomez.Helper;
using FribergHomez.Mappings;
using FribergHomez.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System.Text.Json.Serialization;

namespace FribergHomez
{
    //All 
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            // Add services to the container.
            string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString));

           

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            //builder.Services.AddSwaggerGen();

            builder.Services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });
                option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
            });

            builder.Services.AddScoped<IFirm, FirmRepository>();
            builder.Services.AddScoped<ISaleObject, SaleObjectRepository>();
            builder.Services.AddScoped<IRealEstateAgent, RealEstateAgentRepository>();
            builder.Services.AddScoped<IMunicipality, MunicipalityRepository>();
            builder.Services.AddScoped<ICategory, CategoryRepository>();
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;                             //test
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero,
                    ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
                    ValidAudience = builder.Configuration["JwtSettings:Audience"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                        builder.Configuration["JwtSettings:Key"]))
                };
            });

            //Cors
            var myOrigin = "ourCors";
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name:"ourCors", policy =>
                {
                    policy.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

            //Identity
          
            //builder.Services.AddIdentity<RealEstateAgent, IdentityRole>(options =>


            builder.Services.AddIdentityCore<RealEstateAgent>(options =>
            {
                options.Password.RequireDigit = true;
                

            })
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            //AutomapperService
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            //Identity

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseHttpsRedirection();

            app.UseRouting();
            //Cors
            app.UseCors(myOrigin);

            app.UseAuthentication();
            app.UseAuthorization();
            

            app.MapControllers();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbContext = services.GetRequiredService<ApplicationDbContext>();


                // Resolve the UserManager
                var userManager = services.GetRequiredService<UserManager<RealEstateAgent>>();
                SeedHelper seedHelper = new SeedHelper(userManager);

                await seedHelper.SeedFirmsAndAgentsAsync(dbContext); 
                await seedHelper.SeedMunicipalitiesAsync(dbContext);
                await seedHelper.SeedCategoriesAsync(dbContext);
                await seedHelper.SeedSaleObjectsAsync(dbContext);
            }
            app.Run();
        }
    }
}