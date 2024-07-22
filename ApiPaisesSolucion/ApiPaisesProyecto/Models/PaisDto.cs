namespace ApiPaisesProyecto.Models
{
    public class PaisDto
    {
        // Clase que representa un país
        // es una clase DTO (Data Transfer Object)
        // que se utiliza para transferir datos entre
        // la capa de acceso a datos y la capa de presentación
        // es una clase POCO (Plain Old CLR Object)

        // Propiedades
        public int Id { get; set; }
        public string? Nombre { get; set; }  
        public string? Capital { get; set; }
        public string? Continente { get; set; }
        public string? Poblacíon { get; set; }
        public string? Moneda { get; set; }
        public string? Prefijo { get; set; }


    }
}
