using eSupport.Services.Equipment.Domain.SeedWork;
using System.Threading.Tasks;

namespace eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentTypeAggregate
{
    public interface IEquipmentTypeRepository : IRepository<EquipmentType>
    {
         Equipments Add(Equipments equipments);

         void Update(Equipments equipments);

         Task<Equipments> GetAsync(int equipmentsId);
    }
}