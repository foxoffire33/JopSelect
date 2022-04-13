using System.Configuration;
using JopSelectData;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAdB2C"));

//builder.Services.AddDbContext<SqlLiteDbContext>();

/*builder.Services.AddEntityFrameworkCosmos();
builder.Services.AddDbContext<CosmosDbContext>(options =>
{
    
    options.UseCosmos(
        builder.Configuration["CosmosDb:EndpointUrl"],
        builder.Configuration["CosmosDb:PrivateKey"], 
        builder.Configuration["CosmosDb:DbName"]);
});
*/
builder.Services.AddDbContext<SqlLiteDbContext>();


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();