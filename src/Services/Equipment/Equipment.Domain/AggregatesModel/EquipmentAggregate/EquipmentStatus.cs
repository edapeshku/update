using eSupport.Services.Equipment.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using global::eSupport.Services.Equipment.Domain.Exceptions;

namespace eSupport.Services.Equipment.Domain.AggregatesModel.EquipmentAggregate
{
    public class EquipmentStatus : Enumeration
    {
        public static EquipmentStatus Submitted = new EquipmentStatus(1, nameof(Submitted).ToLowerInvariant());
        public static EquipmentStatus Active = new EquipmentStatus(2, nameof(Active).ToLowerInvariant());
        public static EquipmentStatus Deleted = new EquipmentStatus(3, nameof(Deleted).ToLowerInvariant());

        protected EquipmentStatus() { }

        public EquipmentStatus(int id, string name)
            : base(id, name)
        {
        }

        public static IEnumerable<EquipmentStatus> List() => 
            new [] { Submitted, Active, Deleted };

        public static EquipmentStatus FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new EquipmentDomainException($"Possible values for EquipmentStatus: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static EquipmentStatus From(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new EquipmentDomainException($"Possible values for EquipmentStatus: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}