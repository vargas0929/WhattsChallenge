using Whatts.Application.Contracts;
using Whatts.Application.Handlers;
using Whatts.Domain.Contracts;
using Whatts.Domain.Handlers;
using Whatts.Infrastructure.Contracts;
using Whatts.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IUserApplication, UserApplication>();

builder.Services.AddScoped<IUserDomain, UserDomain>();
builder.Services.AddScoped<IUserRepository, UserRepository>();




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


