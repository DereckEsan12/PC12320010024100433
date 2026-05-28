using Microsoft.AspNetCore.Mvc;
using PC12320010024100433.core.Core.DTOs;
using PC12320010024100433.core.Core.Interfaces;

namespace PC12320010024100433.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoServicioController : ControllerBase
    {
        private readonly ITipoServicioService _tipoServicioService;

        public TipoServicioController(ITipoServicioService tipoServicioService)
        {
            _tipoServicioService = tipoServicioService;
        }

        // GET api/tiposervicio
        [HttpGet]
        public async Task<IActionResult> GetTipoServicios()
        {
            var servicios = await _tipoServicioService.GetTipoServicios();
            return Ok(servicios);
        }

        // GET api/tiposervicio/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTipoServicioById(int id)
        {
            var servicio = await _tipoServicioService.GetTipoServicioById(id);
            if (servicio == null)
            {
                return NotFound();
            }
            return Ok(servicio);
        }

        // POST api/tiposervicio
        [HttpPost]
        public async Task<IActionResult> CreateTipoServicio([FromBody] TipoServicioCreateDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            await _tipoServicioService.CreateTipoServicio(dto);
            return Ok();
        }

        // PUT api/tiposervicio
        [HttpPut]
        public async Task<IActionResult> UpdateTipoServicio([FromBody] TipoServicioUpdateDTO dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var existing = await _tipoServicioService.GetTipoServicioById(dto.Id);
            if (existing == null)
            {
                return NotFound();
            }

            await _tipoServicioService.UpdateTipoServicio(dto);
            return NoContent();
        }

        // DELETE api/tiposervicio/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipoServicio([FromBody] TipoServicioDeleteDTO dto)
        {
            var existing = await _tipoServicioService.GetTipoServicioById(dto.Id);
            if (existing == null)
            {
                return NotFound();
            }

            await _tipoServicioService.DeleteTipoServicio(dto);
            return NoContent();
        }
    }
}
