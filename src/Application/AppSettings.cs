using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSupport.Application
{
     public class AppSettings
    {
        public Connectionstrings ConnectionStrings { get; set; }
        public string ClientUrl { get; set; }
        public string EmailUrl { get; set; }
        public string EquipmentUrl { get; set; }
        public string InvoiceUrl { get; set; }
        public string SolutionUrl { get; set; }
        public string UserUrl { get; set; }
        public Logging Logging { get; set; }
    }

    public class Connectionstrings
    {
        public string DefaultConnection { get; set; }
    }

    public class Logging
    {
        public bool IncludeScopes { get; set; }
        public Loglevel LogLevel { get; set; }
    }

    public class Loglevel
    {
        public string Default { get; set; }
        public string System { get; set; }
        public string Microsoft { get; set; }
    }
}