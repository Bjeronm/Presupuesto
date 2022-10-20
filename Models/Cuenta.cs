using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
    public class Cuenta
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }
        [Display(Name ="Tipos de Cuenta")]
        public int TipoCuentaId { get; set; }
        public decimal Balance { get; set; }
        public string Descripcion { get; set; }
    }
}
