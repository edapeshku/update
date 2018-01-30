using eSupport.Services.Equipment.Domain.SeedWork;
using System.Threading.Tasks;

namespace eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentAggregate
{
    public interface IEquipmentRepository : IRepository<Equipments>
    {
         Equipments Add(Equipments equipments);

         void Update(Equipments equipments);

         Task<Equipments> GetAsync(int equipmentsId);
    }
}