var builder = WebApplication.CreateBuilder(args);

// L�gg till services f�r API och Swagger
builder.Services.AddControllers(); // L�gg till detta f�r att st�dja controllers
builder.Services.AddEndpointsApiExplorer(); // L�gg till f�r att kunna skapa Swagger
builder.Services.AddSwaggerGen(); // L�gg till f�r att generera Swagger/OpenAPI-dokumentation

var app = builder.Build();

// Aktivera Swagger UI i utvecklingsmilj�
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Generera Swagger-dokumentation
    app.UseSwaggerUI(); // Visa Swagger UI
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers(); // Detta mappar alla controllers, t.ex. EncryptionController

app.Run();
