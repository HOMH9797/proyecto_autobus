using System.ComponentModel.DataAnnotations;

namespace api_web_servicio_bus.DAL.Entities
{
    public class Usuario : AuditBase
    {
        [Display(Name = "Nombre Cliente"),Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(150, ErrorMessage ="El campo {0} debe tener máximo {1}")]
        public string Name { get; set; }

        [Display(Name = "Numero Documento"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string id_number { get; set; }
        [Display(Name = "Correo"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string email { get; set; }
        [Display(Name = "sexo"), Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string gender { get; set; }
        [Display(Name = "Direccion")]
        public ICollection<Direccion>? address { get; set; }
        [Display(Name = "Telefono")]
        public ICollection<Telefono>? phone { get; set; }
        [Display(Name = "Reserva")]
        public ICollection<Reserva>? reservation { get; set; }
    }
}
