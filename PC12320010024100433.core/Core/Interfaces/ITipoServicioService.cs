using PC12320010024100433.core.Core.DTOs;

namespace PC12320010024100433.core.Core.Interfaces
{
    public interface ITipoServicioService
    {
        Task CreateTipoServicio(TipoServicioCreateDTO dto);
        Task DeleteTipoServicio(TipoServicioDeleteDTO dto);
        Task<TipoServicioListDTO> GetTipoServicioById(int id);
        Task<IEnumerable<TipoServicioListDTO>> GetTipoServicios();
        Task UpdateTipoServicio(TipoServicioUpdateDTO dto);
    }
}