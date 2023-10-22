using Hostel_Manager.API.Data;
using Hostel_Manager.API.Entities;
using Hostel_Manager.API.Repositories;
using Hostel_Manager.API.Repositories.Contract;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using static Hostel_Manager.API.Entities.User;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<HostelDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HostelManagerConnection")));
builder.Services.AddScoped<IHostelRepository, HostelRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(policy =>
    policy.WithOrigins("https://localhost:7068", "https://localhost:7068/")
    .AllowAnyMethod()
    .WithHeaders(HeaderNames.ContentType)
    );
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
