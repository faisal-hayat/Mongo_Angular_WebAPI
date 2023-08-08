using Amazon.Auth.AccessControlPolicy;
using Microsoft.Extensions.DependencyInjection;
using MongDbWebAPI.Configration;
using MongDbWebAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// This is where we will be adding the mongoDb here
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("MongoDatabase"));
// This is where we will be adding the services
builder.Services.AddSingleton<DriverService>();
// Add CORS Rules
builder.Services.AddCors(options => options.AddPolicy("AngularClient", policy =>
{
    policy.WithOrigins("http://localhost:4200/").AllowAnyMethod().AllowAnyOrigin();
}));

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
app.UseCors("AngularClient");
app.Run();
