using Enrollment.Database.Extentions;
using SmartFlix.API.Configuration.Extentions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
                .ConfigNewtonsoftJson();

builder.Services.AddCors();

builder.Services.ConfigJwtBearerAuthentication(builder.Configuration.GetValue<string>("Params:Key"));

builder.Services.AddSqlDatabaseContext(builder.Configuration["ConnectionString"])
                .ModuleInjections()
                .AddEndpointsApiExplorer()
                .ConfigSwagger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();


app.UseCors(
    _ => _.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowAnyOrigin()
);

app.UseAuthorization();

app.MapControllers();

app.Run();
