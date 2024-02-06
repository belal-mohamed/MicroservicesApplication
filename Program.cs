using Microsoft.EntityFrameworkCore;
using PlatformService.Infrastructure.Data.DatabaseContext;
using PlatformService.Infrastructure.Repositories;
using PlatformService.Infrastructure.Seeding;
using PlatformService.Models.Interfaces.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


// AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Register Ef Core DbContext
builder
    .Services
    .AddDbContext<AppDbContext>(opt => 
        opt.UseInMemoryDatabase("InMem")
        );



//Register Repositories
builder
    .Services
    .AddScoped<IPlatformRepository, PlatformRepository>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

SeederDb.SeedData(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
