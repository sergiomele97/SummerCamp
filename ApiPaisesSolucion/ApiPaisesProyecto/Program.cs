// Builder -> Constructor de la aplicación
var builder = WebApplication.CreateBuilder(args);

// 1- Agregar servicios a la aplicación
// ====================================

// Agregar un servicio de Modelo-Vista-Controlador
builder.Services.AddControllers();

// Agregar Swagger (OpenAPI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// app -> aplicación
var app = builder.Build();


// 2- Configurar middleware
// ====================================

// Comprobar si estamos en un entorno de desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redirección de http a https
app.UseHttpsRedirection();


// Agregar el middleware de autorización
app.UseAuthorization();

// Agregar el middleware de enrutamiento
// enrutamiento -> Determina que controlar y acción se ejecutará
// en función de la URL solicitada
app.MapControllers();


//app.MapGet("/", () => "Hello World!");
//app.MapGet("/paises", () => new string[] { "Argentina", "Brasil", "Chile" });
//app.UseWelcomePage();


// 3- Ejecutar la aplicación
// ====================================
app.Run();
