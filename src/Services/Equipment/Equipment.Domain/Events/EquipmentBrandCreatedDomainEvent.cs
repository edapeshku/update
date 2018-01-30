using MediatR;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentBrandAggregate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eSupport.Services.Equipment.Domain.Events
{
    public class EquipmentBrandCreatedDomainEvent : INotification
    {
        public string UserId { get; private set; }
        public string Name { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public EquipmentBrand EquipmentBrand { get; private set; }

        public EquipmentBrandCreatedDomainEvent(
            EquipmentBrand equipmentBrand, 
            string userId,
            bool active, 
            DateTime createdAt
        ) {
            EquipmentBrand = equipmentBrand;
            UserId = userId;
            Active = active;
            CreatedAt = createdAt;
        }
    }
}