using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        // Activa o descativa el Schedule
        public int Available { get; set; }
        // FK a Webinar
        public int Webinar_Id { get; set; }
        public Webinar Webinar { get; set; }
    }
        
}
