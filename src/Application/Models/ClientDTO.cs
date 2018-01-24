using System;
using System.ComponentModel.DataAnnotations;

namespace eSupport.Application.Models
{
    public class ClientDTO
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        public string City { get; set; }
       
        [Required]
        public string Street { get; set; }
        
        [Required]
        public string State { get; set; }
        
        [Required]
        public string Country { get; set; }

        public string ZipCode { get; set; }
    }
}