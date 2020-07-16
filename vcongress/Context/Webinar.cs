using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class Webinar
    {
      public int WebinarId { get; set; }
    // Sirve para poner el tema del Webinar
      public string WebinarTheme { get; set; }
      public DateTime WebinarInitialDate { get; set; }
      public DateTime WebinarEndDate { get; set; }
      public int UserCount { get; set; }
      public int available { get; set; }

     
     // FALTA ID A ASPNET USERS
     error 
      // Permite a Schedule acceder a la Data
      public ICollection<Schedule> Schedules { get; set; }


    }
}
