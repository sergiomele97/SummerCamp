// Builder -> Constructor de la aplicaci�n
var builder = WebApplication.CreateBuilder(args);

// 1- Agregar servicios a la aplicaci�n
// ====================================

// Agregar un servicio de Modelo-Vista-Controlador
builder.Services.AddControllers();

// Agregar Swagger (OpenAPI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// app -> aplicaci�n
var app = builder.Build();


// 2- Configurar middleware
// ====================================

// Comprobar si estamos en un entorno de desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Redirecci�n de http a https
app.UseHttpsRedirection();


// Agregar el middleware de autorizaci�n
app.UseAuthorization();

// Agregar el middleware de enrutamiento
// enrutamiento -> Determina que controlar y acci�n se ejecutar�
// en funci�n de la URL solicitada
app.MapControllers();


//app.MapGet("/", () => "Hello World!");
//app.MapGet("/paises", () => new string[] { "Argentina", "Brasil", "Chile" });
//app.UseWelcomePage();


// 3- Ejecutar la aplicaci�n
// ====================================
app.Run();
