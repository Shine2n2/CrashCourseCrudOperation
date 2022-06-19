using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels
{
    public class CarDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EngineType { get; set; }
        public string Color { get; set; }
        public decimal Amount { get; set; }
        public int OrganizationId { get; set; }
    }
}
