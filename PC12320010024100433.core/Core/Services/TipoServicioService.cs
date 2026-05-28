using PC12320010024100433.core.Core.DTOs;
using PC12320010024100433.core.Core.Entities;
using PC12320010024100433.core.Core.Interfaces;

namespace PC12320010024100433.core.Core.Services
{
    public class TipoServicioService : ITipoServicioService
    {
        private readonly ITipoServicioRepository _tipoServicioRepository;

        public TipoServicioService(ITipoServicioRepository tipoServicioRepository)
        {
            _tipoServicioRepository = tipoServicioRepository;
        }

        public async Task<IEnumerable<TipoServicioListDTO>> GetTipoServicios()
        {
            var servicios = await _tipoServicioRepository.GetTipoServicios();
            return servicios.Select(s => new TipoServicioListDTO
            {
                Id = s.Id,
                Nombre = s.Nombre
            }).ToList();
        }

        public async Task<TipoServicioListDTO> GetTipoServicioById(int id)
        {
            var servicio = await _tipoServicioRepository.GetTipoServicioById(id);
            if (servicio == null) return null;

            return new TipoServicioListDTO
            {
                Id = servicio.Id,
                Nombre = servicio.Nombre
            };
        }

        public async Task CreateTipoServicio(TipoServicioCreateDTO dto)
        {
            var servicio = new TipoServicio
            {
                Nombre = dto.Nombre,
                PrecioBase = dto.PrecioBase
            };
            await _tipoServicioRepository.CreateTipoServicio(servicio);
        }

        public async Task UpdateTipoServicio(TipoServicioUpdateDTO dto)
        {
            var servicio = await _tipoServicioRepository.GetTipoServicioById(dto.Id);
            if (servicio != null)
            {
                servicio.Nombre = dto.Nombre;
                servicio.PrecioBase = dto.PrecioBase;
                await _tipoServicioRepository.UpdateTipoServicio(servicio);
            }
        }

        public async Task DeleteTipoServicio(TipoServicioDeleteDTO dto)
        {
            await _tipoServicioRepository.DeleteTipoServicio(dto.Id);
        }
    }
}
