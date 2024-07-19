using AuthenticationDemo.Data;
using AuthenticationDemo.Interface;
using AuthenticationDemo.Module;
using Microsoft.AspNetCore.Http.HttpResults;

namespace AuthenticationDemo.Repository
{
    public class DistrictRepository : IDistrict
    {
        private readonly ApplicationDbContext _context;

        public DistrictRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddDistrict(District district)
        {
            try
            {
                _context.Districts.Add(district);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool DeleteDistrict(int Id)
        {
            try
            {
                var district = _context.Districts.Find(Id);
                _context.Districts.Remove(district);
                _context.SaveChanges();
                 return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<District> GetAllDistricts()
        {
            try
            {
                return _context.Districts.ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }

        public District GetDistrictById(int Id)
        {
            try
            {
                return _context.Districts.Find(Id);
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool UpdateDistrict(District district)
        {
            try
            {
                _context.Districts.Update(district);
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
