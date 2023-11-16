using api_web_servicio_bus.DAL.Entities;
using api_web_servicio_bus.Domain.Interfaces;

namespace api_web_servicio_bus.Domain.Services
{
    public class DireccionService : IDireccion
    {
        public Task<IEnumerable<Direccion>> GetDireccionessAsync()
        {
            throw new NotImplementedException();
        }
    }
}
