using MatchingAlgo.Configurations;
using MatchingAlgo.Data;
using MatchingAlgo.Helpers;
using MatchingAlgo.IRepository;
using MatchingAlgo.Repository;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using System.Diagnostics.Metrics;

var builder = WebApplication.CreateBuilder(args);


Log.Logger = new LoggerConfiguration().WriteTo.File(
    path: "c:\\matchingAlgo\\logs\\log-.txt",
    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level3}] {Message:lj}{NewLine}{Exception}",
    rollingInterval: RollingInterval.Day,
    restrictedToMinimumLevel: LogEventLevel.Information
    ).CreateLogger();
builder.Host.UseSerilog();

//Add DbContext
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection"),
    x => x.UseNetTopologySuite())
);
// Add services to the container.
builder.Services.AddControllers();
//Add Cors Policy
builder.Services.AddCors(o =>
{
    o.AddPolicy("AllowAll", b =>
        b.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});
//Add AutoMapper
builder.Services.AddAutoMapper(typeof(MapperInitilizer));
//Register IOU
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers().AddNewtonsoftJson(op =>
    op.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddSwaggerGen();

try
{
    Log.Information("Application Is Started");
    var app = builder.Build();
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    
    app.UseHttpsRedirection();

    app.UseCors("AllowAll");

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application failed To Start");

}
finally
{
    Log.CloseAndFlush();
}


