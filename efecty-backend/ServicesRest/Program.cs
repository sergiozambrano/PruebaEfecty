using Microsoft.EntityFrameworkCore;
using ServicesRest.Application.Abstract;
using ServicesRest.Application.Service;
using ServicesRest.Domain.Abstract;
using ServicesRest.Infrastructure.DataAccess;
using ServicesRest.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("efecty");

builder.Services.AddDbContext<EfectyContext>(options =>
     options.UseSqlServer(connectionString)
);

builder.Services.AddScoped<IRecruitmentRepository, RecruitmentRepository>();
builder.Services.AddScoped<IRecruitmentService, RecruitmentService>();

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
