using Application.Interfaces;

namespace Application.Events
{
    public class QuoteCreatedEvent : IEvent
    {
        public int Id { get; set; }
    }
}
