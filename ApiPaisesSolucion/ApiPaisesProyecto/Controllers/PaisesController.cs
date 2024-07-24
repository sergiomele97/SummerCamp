namespace ApiPaisesProyecto.Controllers
{
    // 1. Ruta de la API
    [Route("api/paises")]
    // 2. Controlador de API
    // Importante para el tema de validaciones
    [ApiController]
    // 3. Hereda de ControllerBase
    // Controlador de paises
    // Nombre de controlador: Paises (Se elemina controller)
    // Prefijo de ruta: api/paises
    // Ruta de controlador: api/paises
    public class PaisesController : ControllerBase
    {
        // a) Atributo HttpGet -> Indica que el método Get() responde a una petición GET
        [HttpGet]
        // b) Método Get() -> Obtiene todos los paises devolviendo un objeto IActionResult
        public IActionResult Get()
        {
            // c) Devuelve un objeto con la lista de paises como parámetro del metodo Ok()
            return Ok(PaisesRepositorioMemoria.Instancia.Paises);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            // El método FirstOrDefault() devuelve el primer elemento de una secuencia o un valor predeterminado si la secuencia no contiene elementos
            // es un método de extensión de LINQ
            return Ok(PaisesRepositorioMemoria.Instancia.Paises.FirstOrDefault(p => p.Id == id));
        }
    }
}
