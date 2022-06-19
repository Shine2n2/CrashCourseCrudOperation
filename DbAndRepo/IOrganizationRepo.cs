using Entities;
using System.Collections.Generic;

namespace DbAndRepo
{
    public interface IOrganizationRepo
    {
        Organization GetById(int id);
        List<Organization> GetOrganizations();
    }
}