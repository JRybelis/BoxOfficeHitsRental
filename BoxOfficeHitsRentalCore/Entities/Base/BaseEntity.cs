using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfficeHitsRentalCore.Entities.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public bool Deleted { get; set; } = false;
    }
}
