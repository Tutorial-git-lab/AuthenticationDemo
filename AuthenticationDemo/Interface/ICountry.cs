using AuthenticationDemo.Module;

namespace AuthenticationDemo.Interface
{
    public interface ICountry
    {
        bool AddCountry (Country country);

        bool UpdateCountry(Country country);

        bool DeleteCountry (int Id);

        List<Country> GetAllCountries();

        Country GetCountryById (int Id);
    }
}
