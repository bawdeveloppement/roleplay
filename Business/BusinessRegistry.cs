using System.Text.Json;

namespace Roleplay.Business
{
    public class BusinessRegistry
    {

        public List<Business> businesses = new();

        public BusinessRegistry()
        {

        }


        public static BusinessRegistry Deserialize(string businessRegistryData)
        {
            BusinessRegistry? businessRegistry = JsonSerializer.Deserialize<BusinessRegistry>(businessRegistryData);

            if (businessRegistry == null) {
                return new BusinessRegistry();
            } else {
                return businessRegistry;
            }
            
        }

        public string Serialize()
        {
            return JsonSerializer.Serialize<BusinessRegistry>(this);
        }
    }
}