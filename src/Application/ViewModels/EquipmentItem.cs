using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace eSupport.Application.ViewModels
{
    public class EquipmentItem
    {
        public string Name { get; set; }
         
        public decimal Price { get; set; }

        public int WarrantyYears { get; set; }

        public string PictureFileName { get; set; }

        public string PictureUri { get; set; }

        public int EquipmentBrandId { get; set; }
        
        public string EquipmentBrand { get; set; }
        
        public int EquipmentTypeId { get; set; }

        public string EquipmentType { get; set; }
    
        public int AvaibleStock { get; set; }

    }
}