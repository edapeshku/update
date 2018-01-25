using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eSupport.Application.ViewModels
{
    public class Client
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public List<ClientItem> Clients { get; set;}

    }
}