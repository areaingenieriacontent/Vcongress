using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vcongress.Context
{
    public class Enterprise
    {
        public int EnterpriseId {get; set;}
        public int EnterpiseNit { get; set; }
        public int EnterpriseVerification { get; set; }
        public string EnterpriseName { get; set; }
        public int Available { get; set; }
        public ICollection<Congress_Enterprise> Congress_Enterprises { get; set; }
        // falt FK a ASPNET USERS

    }
}
