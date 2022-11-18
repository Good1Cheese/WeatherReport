var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();
services.AddHttpClient();

services.AddCors(setup =>
{
    setup.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("http://localhost:5184");
    });
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseCors();

app.Run();
