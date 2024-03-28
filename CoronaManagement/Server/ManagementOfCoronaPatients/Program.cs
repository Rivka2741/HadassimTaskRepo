using AutoMapper;
using Bll;
using Dal;
using Entity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Identity.Client;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IUserBll, UserBll>();
builder.Services.AddScoped<IUserDal, UserDal>();
builder.Services.AddScoped<ISickWithCoronaBll, SickWithCoronaBll>();
builder.Services.AddScoped<ISickWithCoronaDal, SickWithCoronaDal>();
builder.Services.AddScoped<IVaccinationDetailBll, VaccinationDetailBll>();
builder.Services.AddScoped<IVaccinationDetailDal, VaccinationDetailDal>();
builder.Services.AddScoped<IVaccineManufacturerBll, VaccineManufacturerBll>();
builder.Services.AddScoped<IVaccineManufacturerDal, VaccineManufacturerDal>();
builder.Services.AddDbContext<CoronaManagementSystemContext>();
var mapConfig = new MapperConfiguration(m =>
{
    m.AddProfile(new AutoMapperProfile());
});
IMapper mapper = mapConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(x => x.AllowAnyHeader()
.AllowAnyOrigin()
.AllowAnyMethod());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

// Inside ConfigureServices method in Startup.cs
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
 
    });

builder.Services.AddAuthorization();

builder.Services.AddAuthorization();

// Inside Configure method in Startup.cs
app.UseAuthentication();
app.UseAuthorization();
