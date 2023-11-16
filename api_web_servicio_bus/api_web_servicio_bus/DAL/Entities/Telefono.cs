using System.ComponentModel.DataAnnotations;

namespace api_web_servicio_bus.DAL.Entities
{
    public class Telefono : AuditBase
    {
        [Display(Name = "Telefono"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string phone_number { get; set; }
        [Display(Name = "Tipo Telefono"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string kind_phone { get; set; }
        [Display(Name = "Id Cliente")]
        public Guid id_cliente { get; set; }
    }
}
