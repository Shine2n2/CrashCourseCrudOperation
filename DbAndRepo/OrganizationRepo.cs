using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAndRepo
{
    public class OrganizationRepo : IOrganizationRepo
    {
        private static List<Organization> AllOrganizations = new List<Organization>
        {
            new Organization
            {
                Name = "EmmanuelCars",
                 Id = 1,
                 Location = "Kaduna",
                  DateFound = DateTime.Now,
            },
            new Organization
            {
                Name = "AzeezCars",
                 Id = 2,
                 Location = "Osun",
                  DateFound = DateTime.Now,
            },
            new Organization
            {
                Name = "EbeleCars",
                 Id = 3,
                 Location = "Jos",
                  DateFound = DateTime.Now,
            },
        };

        public List<Organization> GetOrganizations()
        {
            return AllOrganizations;
        }

        public Organization GetById(int id)
        {
            if (AllOrganizations.Any(o => o.Id == id))
            {
                return AllOrganizations.FirstOrDefault(o => o.Id == id);
            }

            throw new Exception($"No Organization Exists with Id {id}");
        }
    }
}
