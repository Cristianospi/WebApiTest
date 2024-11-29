using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using WebApiTest.DAL.Entities;

namespace WebApiTest.DAL
{
    public class DataBaseContext: DbContext
    {
        //Asi me conecto a la BD por medio de este constructor
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        
       //Este metodo que es propio de EF CORE me sirve para configurar unos indices de cada campo de una tabla de BD
        /* Protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //  base.OnModelCreating(modelBuilder);
         //   modelBuilder.Entity<Country>().HasIndex(c=> c.Name).IsUnique(); // aqui creo un indice del campo para el name 
        para la tabla Countries
        }*/
   
        
        #region DbSet

        public DbSet<Country> Countries { get; set; }

        #endregion
    }
}
