using System.ComponentModel.DataAnnotations;

namespace WebAPITest.DAL.Entities
{
    public class Country
    {
        [Required(ErrorMessage = "El campo {0} es olbigatorio")] // Obligatorio
        [MaxLength(50, ErrorMessage ="El campo {0} dbe tener maximo {1} caracteres")] //Longitud MAxima
        [Display(Name = "Pais")] // Identificar Nombre  
        public String Name { get; set; }
    }
}
