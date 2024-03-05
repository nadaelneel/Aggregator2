using Deopartments.Application;
using Deopartments.Application.Service;
using Departments.Infrastracture;
using Departments.Infrastracture.Context;
using Departments.Infrastracture.Reposatories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
#region dependence injection
builder.Services
    .AddInfrastractureDependencies();
#endregion
builder.Services.AddDbContext<AppDbContext>(i =>
{
    i.UseSqlServer(builder.Configuration.GetConnectionString("AppDb"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//3

builder.Services.AddGrpc();
builder.Services.AddGrpcReflection();
//1
builder.Services.AddTransient(typeof(DepartmentReposatory));
//builder.Services.AddMediatR(cfg => { cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()); });

//builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(typeof(ApplicationLayer));
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining(typeof(ApplicationLayer)));

builder.Services.AddSwaggerGen();

var app = builder.Build();
//2

//// Configure the HTTP request pipeline.
///
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGrpcService<DepartmentsService>();
//4
app.MapGrpcReflectionService();

app.UseHttpsRedirection();

app.UseAuthorization();


app.MapControllers();

app.Run();
