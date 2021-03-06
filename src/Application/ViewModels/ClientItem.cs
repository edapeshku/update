using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace eSupport.Application.ViewModels
{
    public class ClientItem
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string City { get; set; }
       
        public string Street { get; set; }
        
        public string State { get; set; }
        
        public string Country { get; set; }

        public string ZipCode { get; set; }
    }
}