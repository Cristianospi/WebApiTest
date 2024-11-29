using System.ComponentModel.DataAnnotations;

namespace WebApiTest.DAL.Entities
{
    public class Country : AudiBase
    {
        [Display(Name = "pais")] // para identificar el nombre mas facil
        [MaxLength(50, ErrorMessage = "el campo{0} debe de tener maximo{1}caracteres")] //longitud máx
        [Required(ErrorMessage = "el campo{0} es obligatorio")] // campo obligatorio
        public string name { get; set; }

    }
}
