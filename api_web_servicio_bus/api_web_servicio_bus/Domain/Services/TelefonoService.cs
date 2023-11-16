using api_web_servicio_bus.DAL.Entities;
using api_web_servicio_bus.Domain.Interfaces;

namespace api_web_servicio_bus.Domain.Services
{
    public class TelefonoService : ITelefono
    {
        public Task<IEnumerable<Telefono>> GetTelefonossAsync()
        {
            throw new NotImplementedException();
        }
    }
}
