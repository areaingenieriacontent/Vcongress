using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
