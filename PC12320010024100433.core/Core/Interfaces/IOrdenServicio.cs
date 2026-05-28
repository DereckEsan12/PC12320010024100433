using PC12320010024100433.core.Core.Entities;

namespace PC12320010024100433.core.Core.Interfaces
{
    public interface IOrdenServicio
    {
        decimal CostoEstimado { get; set; }
        string DescripcionProblema { get; set; }
        string Estado { get; set; }
        DateTime FechaIngreso { get; set; }
        int Id { get; set; }
        TipoServicio TipoServicio { get; set; }
        int TipoServicioId { get; set; }
        Vehiculo Vehiculo { get; set; }
        int VehiculoId { get; set; }
    }
}