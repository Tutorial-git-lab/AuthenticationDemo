using AuthenticationDemo.Data;
using AuthenticationDemo.Interface;
using AuthenticationDemo.Module;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AuthenticationDemo.Repository
{
    public class CountryRepository : ICountry
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddCountry(Country country)
        {
            try
            {
                _context.Countries.Add(country);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

               return false;
            }
        }

        public bool DeleteCountry(int Id)
        {
            try
            {
                var country = _context.Countries.Find(Id);
                _context.Countries.Remove(country);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        
        public List<Country> GetAllCountries()
        {
            try
            {
                return _context.Countries.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Country GetCountryById(int Id)
        {
            try
            {
                return _context.Countries.Find(Id);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool UpdateCountry(Country country)
        {
            try
            {
                _context.Countries.Update(country);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
