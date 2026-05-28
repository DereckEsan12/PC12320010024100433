using PC12320010024100433.core.Core.Entities;

namespace PC12320010024100433.core.Core.Interfaces
{
    public interface ITipoServicioRepository
    {
        Task CreateTipoServicio(TipoServicio tipoServicio);
        Task DeleteTipoServicio(int id);
        Task<TipoServicio> GetTipoServicioById(int id);
        Task<IEnumerable<TipoServicio>> GetTipoServicios();
        Task UpdateTipoServicio(TipoServicio tipoServicio);
    }
}