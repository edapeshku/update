using System;
using System.Collections.Generic;
using System.Text;

namespace eSupport.Events.CommandBus
{
    public abstract class IntegrationCommand
    {
        public Giud Id { get; private set; }

        public DateTime Sent { get; private set; }

        protected IntegrationCommand()
        {
            Id = Giud.NewGuid();
            Sent = DateTime.UtcNow;
        }
    }
}