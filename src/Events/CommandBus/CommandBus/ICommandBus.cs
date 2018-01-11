using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Task;

namespace eSupport.Events.CommandBus
{
    public interface ICommandBus
    {
        Task SendAsync<T>(T command) where T : IntegrationCommand;
    }
}