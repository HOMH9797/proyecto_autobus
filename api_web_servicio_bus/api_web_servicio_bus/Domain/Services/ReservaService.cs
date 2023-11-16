using api_web_servicio_bus.DAL.Entities;
using api_web_servicio_bus.Domain.Interfaces;

namespace api_web_servicio_bus.Domain.Services
{
    public class ReservaService : IReserva
    {
        public Task<IEnumerable<Reserva>> GetReservasAsync()
        {
            throw new NotImplementedException();
        }
    }
}
