using MediatR;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentTypeAggregate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eSupport.Services.Equipment.Domain.Events
{
    public class EquipmentTypeCreatedDomainEvent : INotification
    {
        public string UserId { get; private set; }
        public string Name { get; private set; }
        public string EquipmentBrandId { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public EquipmentType EquipmentType { get; private set; }

        public EquipmentTypeCreatedDomainEvent(
            EquipmentType equipmentType, 
            string userId,
            string equipmentBrandId, 
            bool active, 
            DateTime createdAt
        ) {
            EquipmentType = equipmentType;
            UserId = userId;
            EquipmentBrandId = equipmentBrandId;
            Active = active;
            CreatedAt = createdAt;
        }
    }
}