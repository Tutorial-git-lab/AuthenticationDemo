using AuthenticationDemo.Module;

namespace AuthenticationDemo.Interface
{
    public interface IDistrict
    {
        bool AddDistrict(District district);


        bool UpdateDistrict(District district);

        bool DeleteDistrict(int Id);

        List<District> GetAllDistricts();

        District GetDistrictById(int Id);

    }
}
