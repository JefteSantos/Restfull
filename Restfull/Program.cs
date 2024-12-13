using System.Text.Json;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.MapGet("/categorias", () =>
{
    var json = File.ReadAllText("Data/categorias.json");
    var categorias = JsonSerializer.Deserialize<List<Categoria>>(json);

    var jsonResult = JsonSerializer.Serialize(categorias);
    return Results.Content(jsonResult, "application/json");
});

app.MapPost("/categorias", (Categoria categoria) =>
{
    var json = File.ReadAllText("Data/categorias.json");
    var categorias = JsonSerializer.Deserialize<List<Categoria>>(json);

    var maxId = categorias?.Max(c => c.Id) ?? 0;
    categoria.Id = maxId + 1;

    categorias?.Add(categoria);

    json = JsonSerializer.Serialize(categorias);
    File.WriteAllText("Data/categorias.json", json);

    return Results.Created($"/categorias/{categoria.Id}", categoria);
});

app.Run();
