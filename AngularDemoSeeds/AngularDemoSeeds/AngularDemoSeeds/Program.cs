using AngularDemoSeeds.EntityFrameworkCore.DataContext;
using AngularDemoSeeds.Utility.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
IConfiguration Configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructure(Configuration);

var app = builder.Build();
//Code to create db if not exists START
{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider.GetRequiredService<AngularDemoSeedDbContext>();
    context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(builder =>
{
    builder.AllowAnyOrigin();
    builder.AllowAnyHeader();
    builder.AllowAnyMethod();
});

app.Run();
