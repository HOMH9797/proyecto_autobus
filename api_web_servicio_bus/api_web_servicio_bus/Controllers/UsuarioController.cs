using api_web_servicio_bus.DAL.Entities;
using api_web_servicio_bus.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace api_web_servicio_bus.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuario _usuarioService;
        
        public UsuarioController(IUsuario usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpGet, ActionName("Get")]
        [Route("GetAll")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuariosAsync()
        {
            var usuarios = await _usuarioService.GetUsuariosAsync();

            if (usuarios == null || !usuarios.Any()) return NotFound();

            return Ok(usuarios);
        }
    }
}
