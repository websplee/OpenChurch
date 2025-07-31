using AutoMapper;
using CrystalBLCore.BusinessServices;
using CrystalBLCore.BusinessServices.Interfaces;
using CrystalBLCore.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using OC.Data;
using OC.Data.Repositories.Interfaces;
using OC.Data.Repositories;
using OC.Data.UnitOfWork;
using OC.Data.UnitOfWork.Interfaces;
using OC.Domain.Models;
using OC.Domain.Models.Members;
using OC.Domain.ViewModels;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add a CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "CorsPolicy",
        builder => builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

builder.Services.AddMvc(options =>
{
    options.EnableEndpointRouting = false;
    options.OutputFormatters.Clear();

    var policy = new AuthorizationPolicyBuilder()
                     .RequireAuthenticatedUser()
                     .Build();
    options.Filters.Add(new AuthorizeFilter(policy));
})
.AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

// Read the connection string from configuration 
var connectionString = builder.Configuration.GetConnectionString("SQLServer");

// Add the database context using the set connection string
builder.Services.AddDbContext<OCDbContext>
    (options => options.UseSqlServer(connectionString));

// Add Email Settings   
var emailConfiguration = builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();

builder.Services.AddSingleton<EmailConfiguration>(emailConfiguration);

builder.Services.AddTransient<IEmailService, EmailService>();

builder.Services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
builder.Services.AddScoped(typeof(IReadOnlyProjectionRepository<,>), typeof(ReadOnlyProjectionRepository<,>));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// Add AutoMapper
// Auto Mapper Configurations
var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new AutoMapperProfile());
});

IMapper mapper = mappingConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                });
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "1.0",
        Title = "Crystal Members APIs",
        Description = "Crystal Standard Members API Implementation",
        TermsOfService = null,
        Contact = new OpenApiContact
        {
            Name = "Humphrey Chinyama",
            Email = "humphrey@crystalisedapps.com",
            Url = new Uri("https://crystalisedapps.com"),
        },
        License = new OpenApiLicense
        {
            Name = "Use under LICX",
            Url = new Uri("https://crystalisedapps.com/license"),
        }
    });
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);

});

var appSettingsSection = builder.Configuration.GetSection("AppSettings").Get<AppSettings>();
builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
// configure jwt authentication
var key = Encoding.ASCII.GetBytes(appSettingsSection.Secret);

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = true;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();
app.UseMiddleware<ApiResponseHandler>();

app.MapControllers();

app.Run();
