using eSupport.Events.EventBus.Events;
using System.Threading.Task;

namespace eSupport.Events.EventBus.Abstractions
{
    public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
        where TIntegrationEvent : IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);
    }

    public interface IIntegrationEventHandler

    {
        
    }
}