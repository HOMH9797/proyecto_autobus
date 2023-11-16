using api_web_servicio_bus.DAL.Entities;

namespace api_web_servicio_bus.Domain.Interfaces
{
    public interface ITelefono
    {
        Task<IEnumerable<Telefono>> GetTelefonossAsync();
    }
}
