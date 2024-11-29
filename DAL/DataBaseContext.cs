using Microsoft.EntityFrameworkCore;
using WebAPITest.DAL.Entities;

namespace WebAPITest.DAL
{
    public class DataBaseContext : DbContext
    {
        // Me conecto a la BD por medio del constructor 
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        // Este metodo me sirve para configurar unos indices de cada campo de una BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); // Aqui creo un indice del campo Name para la tabla Countries

        }

        #region Dbsets
        public DbSet<Country> Countries { get; set; }
        
        #endregion
    }
}
