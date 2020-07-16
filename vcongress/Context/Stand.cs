using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class Stand
    {
        public int Stand_id { get; set; }
        public int StandTypeId { get; set; }
        public Stand_Type Stand_Type { get; set; }
        public int Available { get; set; }
        public ICollection<Congress_Enterprise> Congress_Enterprises { get; set; }
        public ICollection<Digital_Resource> Digital_Resources { get; set; }
    }
}
