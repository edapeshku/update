namespace eSupport.Services.Equipment.API.Model
{
    public class EquipmentItem
    {
        public int Id { get; set; }

        public string Name { get; set; }
         
        public decimal Price { get; set; }

        public int WarrantyYears { get; set; }

        public string PictureFileName { get; set; }

        public string PictureUri { get; set; }

        public int EquipmentBrandId { get; set; }
        public EquipmentBrand EquipmentBrand { get; set; }
        
        public int EquipmentTypeId { get; set; }
        public EquipmentType EquipmentType { get; set; }
    
        public int AvaibleStock { get; set; }
        public EquipmentItem() {}
    }
}