using Entities.ViewModels;
using System.Collections.Generic;

namespace CrashCourse.ViewModels
{
    public class CarHomeViewModel
    {
        public List<CarDTO> Cars { get; set; }
        public OrganizationDTO Organization { get; set; }
    }
}
