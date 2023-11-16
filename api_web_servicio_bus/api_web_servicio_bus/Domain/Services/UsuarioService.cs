using api_web_servicio_bus.DAL;
using api_web_servicio_bus.DAL.Entities;
using api_web_servicio_bus.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_web_servicio_bus.Domain.Services
{
    public class UsuarioService : IUsuario
    {
        private readonly DataBaseContext _context;
        public UsuarioService(DataBaseContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Usuario>> GetUsuariosAsync()
        {
            var usuarios_list = await _context.Usuarios.Include(c => c.phone).Include(c => c.address).ToListAsync();

            return usuarios_list;

                 
        }
    }
}
