using Application.Interfaces;

namespace Application.Events
{
    public class QuoteItemAddedToQuoteEvent : IEvent
    {
        public int QuoteId  { get; set; }
        public int QuoteItemId { get; set; }
    }
}
