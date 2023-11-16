using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace api_web_servicio_bus.DAL.Entities
{
    public class Direccion : AuditBase
    {
        [Display(Name = "Dirección"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string address { get; set; }
        [Display(Name = "Ciudad"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string city { get; set; }
        [Display(Name = "Dirección habilitada"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DefaultValue(true)]
        public bool Availability { get; set; }

        [Display(Name = "Id Cliente")]
        public Guid id_cliente { get; set; }
    }
}
