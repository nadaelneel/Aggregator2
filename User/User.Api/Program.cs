using Microsoft.EntityFrameworkCore;
using System.Reflection;
using User.Application;
using User.Infrastracture;
using User.Infrastracture.Reposatories;
using UserApp.Application.Service;
using UserApp.Infrastracture.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//#region dependence injection
//builder.Services
//    .AddInfrastractureDependencies()
//    .AddModulesAppDependencies();
//#endregion

builder.Services.AddDbContext<AppDbContext>(i =>
{
    i.UseSqlServer(builder.Configuration.GetConnectionString("AppDb"));
});
builder.Services.AddAutoMapper(typeof(ApplicationLayer));
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining(typeof(ApplicationLayer)));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();
builder.Services.AddTransient(typeof(UserReposatory));
builder.Services.AddTransient(typeof(Manger<>));
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
//app.UseMiddleware<ErrorHandlerMiddleware>();
app.MapGrpcService<UserService>();
app.MapGrpcReflectionService();
app.MapControllers();

app.Run();
