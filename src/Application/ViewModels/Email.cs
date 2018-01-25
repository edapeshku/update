using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace eSupport.Application.ViewModels
{
    public class Email
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }

        public List<EmailItem> Emails { get; set; }
    }
}