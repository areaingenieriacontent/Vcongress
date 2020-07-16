using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class Stand_Resource
    {
        public int StandId { get; set; }
        public Stand Stand { get; set; }
        public int DResourceId {get; set;}
        public Digital_Resource Digital_Resource { get; set; }
    }
}
