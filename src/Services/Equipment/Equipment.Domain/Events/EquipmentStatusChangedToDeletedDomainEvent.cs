using MediatR;
using System.Collections.Generic;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentAggregate;

namespace eSupport.Services.Equipment.Domain.Events
{
    public class EquipmentStatusChangedToDeletedDomainEvent : INotification
    {
        public int EquipmentId { get; }

        public EquipmentStatusChangedToDeletedDomainEvent(int equipmentId)
        {
            EquipmentId = equipmentId;
        }
    }
}