using System;

namespace Entities.ViewModels
{
    public class OrganizationDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime DateFound { get; set; }
    }
}
