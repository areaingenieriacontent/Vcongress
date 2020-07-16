using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class Congress
    {
       public int  CongressId { get; set; }
       public string CongressName { get; set; }
       public string CongressTheme { get; set; }
       public DateTime CongressInitialDate { get; set; }
       public DateTime CongressFinalDate { get; set; }
       public int Available { get; set; }
        public ICollection<Congress_Enterprise> congress_Enterprises { get; set; }
    }
}
