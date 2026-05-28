namespace PC12320010024100433.core.Core.DTOs
{
    public class TipoServicioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }
    }

    public class TipoServicioListDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }

    public class TipoServicioCreateDTO
    {
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }
    }

    public class TipoServicioUpdateDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioBase { get; set; }
    }

    public class TipoServicioDeleteDTO
    {
        public int Id { get; set; }
    }
}
