using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class UserInteractions
    {
       public int UserInteractionsId { get; set; }
       // FALTA FK a Usuarios
       public int StandId { get; set; }
       public int StandCount { get; set; }
       public int ResourceId { get; set; }
       public int ResourceCount { get; set; }
       public int WebinarId { get; set; }
    }
}
