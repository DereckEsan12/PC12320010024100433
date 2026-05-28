using Microsoft.EntityFrameworkCore;
using PC12320010024100433.core.Core.Entities;
using PC12320010024100433.core.Core.Interfaces;
using PC12320010024100433.core.Infrastructure.Data;

namespace PC12320010024100433.core.Infrastructure.Repositories
{
    public class TipoServicioRepository : ITipoServicioRepository
    {
        private readonly TallerMecanicoDbContext _context;

        public TipoServicioRepository(TallerMecanicoDbContext context)
        {
            _context = context;
        }

        // Obtener todos los TipoServicio
        public async Task<IEnumerable<TipoServicio>> GetTipoServicios()
        {
            return await _context.TipoServicio.ToListAsync();
        }

        // Obtener TipoServicio por Id
        public async Task<TipoServicio> GetTipoServicioById(int id)
        {
            return await _context.TipoServicio
                                 .Where(ts => ts.Id == id)
                                 .FirstOrDefaultAsync();
        }

        // Crear TipoServicio
        public async Task CreateTipoServicio(TipoServicio tipoServicio)
        {
            _context.TipoServicio.Add(tipoServicio);
            await _context.SaveChangesAsync();
        }

        // Actualizar TipoServicio
        public async Task UpdateTipoServicio(TipoServicio tipoServicio)
        {
            var existing = await _context.TipoServicio
                                         .Where(ts => ts.Id == tipoServicio.Id)
                                         .FirstOrDefaultAsync();
            if (existing != null)
            {
                existing.Nombre = tipoServicio.Nombre;
                existing.PrecioBase = tipoServicio.PrecioBase;
                await _context.SaveChangesAsync();
            }
        }

        // Eliminar TipoServicio (soft delete)
        public async Task DeleteTipoServicio(int id)
        {
            var existing = await _context.TipoServicio
                                         .Where(ts => ts.Id == id)
                                         .FirstOrDefaultAsync();
            if (existing != null)
            {
                // Aquí puedes decidir si haces un "soft delete" como en Category (IsActive=false)
                // o un hard delete. Como TipoServicio no tiene IsActive, lo removemos directamente.
                _context.TipoServicio.Remove(existing);
                await _context.SaveChangesAsync();
            }
        }
    }
}
