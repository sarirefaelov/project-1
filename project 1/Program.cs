using Clinic.Core.Repositories;
using Clinic.Core.Services;
using Clinic.Data;
using Clinic.Data.Repositories;
using Clinic.Service;
using ClinicProject;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<ITurnService, TurnService>();
builder.Services.AddScoped<ITurnRepository, TurnRepository>();
builder.Services.AddScoped<IClientcsService, ClientcsService>();
builder.Services.AddScoped<IClientcsRepository, ClientcsRepository>();


builder.Services.AddSingleton<DataContext>();
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
