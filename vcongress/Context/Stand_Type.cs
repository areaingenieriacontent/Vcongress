using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class Stand_Type
    {
        public int StandType { get; set; }
        public string StandName { get; set; }
        public string EnterpriseLogo { get; set; }
        public string EnterpriseBanner { get; set; }
        public string StandBody { get; set; }
        public string StandResourceA { get; set; }
        public string StandResourceB { get; set; }
        public string StandResourceC { get; set; }
        public ICollection<Stand> Stands { get; set; }
    }
}
