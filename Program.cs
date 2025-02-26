var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/", () => "Hello World!");


app.MapGet("add", () => "API is running!");

app.MapGet("yo", () => "Funkar det?");


var port = Environment.GetEnvironmentVariable("PORT") ?? "5000";
app.Run();
