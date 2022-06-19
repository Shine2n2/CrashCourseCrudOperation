using DbAndRepo;
using Entities.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IOrganizationRepo _organizationRepo;
        public OrganizationService(IOrganizationRepo organizationRepo)
        {
            _organizationRepo = organizationRepo;
        }

        public OrganizationDTO GetById(int id)
        {
            var org = _organizationRepo.GetById(id);
            return new OrganizationDTO
            {
                DateFound = org.DateFound,
                Id = org.Id,
                Location = org.Location,
                Name = org.Name,
            };
        }

        public List<OrganizationDTO> GetOrganizations()
        {
            var orgs = _organizationRepo.GetOrganizations();
            var result = new List<OrganizationDTO>();
            foreach (var org in orgs)
            {
                result.Add(new OrganizationDTO
                {
                    DateFound = org.DateFound,
                    Id = org.Id,
                    Location = org.Location,
                    Name = org.Name,
                });
            }
            return result;
        }
    }
}
