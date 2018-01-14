using System;

namespace eSupport.Services.Equipment.API.Infrastructure.Exceptions
{
    public class EquipmentDomainException : Exception
    {
        public EquipmentDomainException(){}

        public EquipmentDomainException(string message)
            : base(message)
        { }

        public EquipmentDomainException(string message, Exception innerException )
            : base (message, innerException)
        { }
    }
}