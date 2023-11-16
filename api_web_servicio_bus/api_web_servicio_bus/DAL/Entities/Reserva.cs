using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace api_web_servicio_bus.DAL.Entities
{
    public class Reserva : AuditBase
    {
        [Display(Name = "Numero tique"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int number_ticket { get; set; }
        [Display(Name = "Ciudad origen"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string city_from { get; set; }
        [Display(Name = "Ciudad destino"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string city_to { get; set; }
        [Display(Name = "Reserva habilitada"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DefaultValue(false)]
        public bool cancel { get; set; }
        [Display(Name = "Reserva pagá"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DefaultValue(false)]
        public bool pago_total { get; set; }
        [Display(Name = "Id Cliente")]
        public Guid id_cliente { get; set; }
    }
}
