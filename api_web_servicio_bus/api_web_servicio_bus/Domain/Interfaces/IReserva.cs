using api_web_servicio_bus.DAL.Entities;

namespace api_web_servicio_bus.Domain.Interfaces
{
    public interface IReserva
    {
        Task<IEnumerable<Reserva>> GetReservasAsync();
    }
}
