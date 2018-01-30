using MediatR;
using eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentAggregate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eSupport.Services.Equipment.Domain.Events
{
    public class EquipmentCreatedDomainEvent : INotification
    {
        public string UserId { get; private set; }
        public string EquipmentTypeId { get; private set; }
        public string EquipmentBrandId { get; private set; }
        public string WarrantyYear { get; private set; }
        public bool Active { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public Equipments Equipments { get; private set; }

        public EquipmentCreatedDomainEvent(
            Equipments equipments, 
            string userId,
            string equipmentTypeId,
            string equipmentBrandId, 
            string warrantyYear, 
            bool active, 
            DateTime createdAt
        ) {
            Equipments = equipments;
            UserId = userId;
            EquipmentTypeId = equipmentTypeId;
            EquipmentBrandId = equipmentBrandId;
            WarrantyYear = warrantyYear;
            Active = active;
            CreatedAt = createdAt;
        }
    }
}