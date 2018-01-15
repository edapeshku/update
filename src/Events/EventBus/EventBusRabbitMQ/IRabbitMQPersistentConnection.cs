using RabbitMQ.Client;
using System;

namespace eSupport.Events.EventBusRabbitMQ
{
    public interface IRabbitMQPersistentConnection 
         : IDisposable
    {
        bool IsConnected { get; set;}

        bool TryConnect();

        IModel CreateModel();
    }
}