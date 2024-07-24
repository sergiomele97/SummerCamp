namespace ApiPaisesProyecto
{
    public class PaisesRepositorioMemoria
    {

        public List<PaisDto> Paises {  get; set; }

        // Creamos una instancia en la propia clase
        // No desaparece de memoria hasta que no se pare la aplicación
        // PATRON SINGLETON
        public static PaisesRepositorioMemoria Instancia { get; } = new PaisesRepositorioMemoria();

        public PaisesRepositorioMemoria()
        {
            // Agregar paises a la lista de paises
            Paises = new List<PaisDto>()
            {
                new PaisDto { Id = 1, Nombre = "España", Capital = "Madrid", Continente = "Europa", Poblacíon = "46.94 millones", Moneda = "Euro", Prefijo = "+34" },
                new PaisDto { Id = 2, Nombre = "México", Capital = "Ciudad de México", Continente = "América", Poblacíon = "128.9 millones", Moneda = "Peso mexicano", Prefijo = "+52" },
                new PaisDto { Id = 3, Nombre = "Japón", Capital = "Tokio", Continente = "Asia", Poblacíon = "125.8 millones", Moneda = "Yen", Prefijo = "+81" },
                new PaisDto { Id = 4, Nombre = "Australia", Capital = "Canberra", Continente = "Oceanía", Poblacíon = "25.69 millones", Moneda = "Dólar australiano", Prefijo = "+61" },
                new PaisDto { Id = 5, Nombre = "Brasil", Capital = "Brasilia", Continente = "América", Poblacíon = "212.6 millones", Moneda = "Real", Prefijo = "+55" },
                new PaisDto { Id = 6, Nombre = "Sudáfrica", Capital = "Pretoria", Continente = "África", Poblacíon = "59.31 millones", Moneda = "Rand", Prefijo = "+27" },
                new PaisDto { Id = 7, Nombre = "India", Capital = "Nueva Delhi", Continente = "Asia", Poblacíon = "1.366 millones", Moneda = "Rupia", Prefijo = "+91" }

            };
        }
    
    }
}
