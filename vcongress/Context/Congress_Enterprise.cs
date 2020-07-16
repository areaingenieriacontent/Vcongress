using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class Congress_Enterprise
    {
        public int CongressId { get; set; }
        public Congress Congress { get; set; }
        public int EnterpriseId { get; set; }
        public Enterprise Enterprise { get; set; }
        public int StandId { get; set; }
        public Stand Stand { get; set; }
    }
}
