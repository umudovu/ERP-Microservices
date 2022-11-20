using EventBus.Base.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Abstractions
{
    public interface IIntegrationEventHandler<TIntegrationEvent>:IntegrationEventHandler where TIntegrationEvent:IntegrationEvent
    {
        Task Handler(TIntegrationEvent @event);
    }

    public interface IntegrationEventHandler
    {
    }
}
