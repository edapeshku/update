using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace eSupport.Application.ViewModels
{
    public class EmailItem
    {
        public int Id { get; set; }

        public string From { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public DateTime SendTime { get; set; }

        public string PictureUri { get; set; }
    
    }
}