using Entities.ViewModels;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IOrganizationService
    {
        OrganizationDTO GetById(int id);
        List<OrganizationDTO> GetOrganizations();
    }
}