using TaskManager.API.Extensions;
using TaskManager.API.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddApplication();

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddMvc(opt => opt.Filters.Add<ExceptionFilter>());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(opt =>
    {
        opt.SwaggerEndpoint("/openapi/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
