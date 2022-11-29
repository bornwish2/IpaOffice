using Framework.Domain.Events;

namespace Framework.ApplicationServices.Contracts.Events
{
    public interface IDomainEventHandler<TDomainEvent> where TDomainEvent : IDomainEvent
    {
        Task Handle(TDomainEvent Event);
    }
}
