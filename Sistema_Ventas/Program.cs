//Using to work Entity Framework
using Microsoft.EntityFrameworkCore;
using Sistema_Ventas.DataAcces;

var builder = WebApplication.CreateBuilder(args);
//Conecting with SQL SERVER

const string ConnectName = "UniversityDb";
var connectionString = builder.Configuration.GetConnectionString(ConnectName);

//const string ConnectName2 = "CursoDb";
//var connectionString2 = builder.Configuration.GetConnectionString(ConnectName2);

builder.Services.AddDbContext<UniversityContext>(options => options.UseSqlServer(connectionString));
//builder.Services.AddDbContext<CursoContext>(options => options.UseSqlServer(connectionString2));






// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
