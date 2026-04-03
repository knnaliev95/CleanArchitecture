using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.WebApi.Controllers;
using CleanArchitecture.WebApi.Controllers.Modules.Admin.Ixtisas;
using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.RateLimiting;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddCors();
builder.Services.AddOpenApi();

builder.Services.AddControllers().AddOData(opt => 
    opt.Select()
    .Filter()
    .Count()
    .Expand()
    .OrderBy()
    .SetMaxTop(null)
    .AddRouteComponents("odata", ODataModelBuilderExtension.GetEdmModel())
);
builder.Services.AddRateLimiter(x =>
x.AddFixedWindowLimiter("fixed", cfg =>
{
    cfg.QueueLimit = 200;
    cfg.Window = TimeSpan.FromSeconds(1);
    cfg.PermitLimit = 200;
    cfg.QueueProcessingOrder = System.Threading.RateLimiting.QueueProcessingOrder.OldestFirst;
}));

var app = builder.Build();

app.MapControllers().RequireRateLimiting("fixed");
app.MapOpenApi();
app.MapScalarApiReference();

app.UseCors(x => x
.AllowAnyHeader()
.AllowCredentials()
.AllowAnyMethod()
.SetIsOriginAllowed(t => true));

app.RegisterRoutes();

app.Run();
