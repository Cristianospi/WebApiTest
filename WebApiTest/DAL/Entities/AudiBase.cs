using System.ComponentModel.DataAnnotations;

namespace WebApiTest.DAL.Entities
{
    public class AudiBase
    {
        [Key] //PK
        [Required] // Significa que este campo es obligatorio

        public virtual Guid Id { get; set; } //  esta sera la PK de todas las tablas
        
        public virtual DateTime CreateDate { get; set; } // para guardar todo registro nuevo con su date 

        public virtual DateTime ModifiedDate { get; set; } // para guardar todo registro que se modifico con su date 


   

    }
}
