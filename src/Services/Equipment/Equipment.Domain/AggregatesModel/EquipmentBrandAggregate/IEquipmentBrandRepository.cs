using eSupport.Services.Equipment.Domain.SeedWork;
using System.Threading.Tasks;

namespace eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentBrandAggregate
{
    public interface IEquipmentBrandRepository : IRepository<EquipmentBrand>
    {
         EquipmentBrand Add(EquipmentBrand equipmentBrand);

         void Update(EquipmentBrand equipmentBrand);

         Task<EquipmentBrand> GetAsync(int equipmentBrandId);
    }
}