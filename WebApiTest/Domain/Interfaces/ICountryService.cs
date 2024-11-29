using WebAPITest.DAL;
using WebAPITest.DAL.Entities;

namespace WebAPITest.Domain.Interfaces
{
    public interface ICountryService
    {

        Task<IEnumerable<Country>> GetCountriesAsync(); //una de las tantas firmas de un metodo!

        Task<Country> CreateCountryAsync(Country country);

        Task<Country> GetCountryByIdAsync(Guid id);

        Task<Country> EditCountryAsync(Country country);

        Task<Country> DeleteCountryAsync(Guid id);
    }
}
