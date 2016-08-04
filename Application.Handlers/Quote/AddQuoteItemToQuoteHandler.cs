using System.Threading.Tasks;
using Application.Commands;
using Application.Events;
using Application.Interfaces;
using DomainModel.Entities;
using DomainModel.Interfaces;

namespace Application.Handlers.Quote
{
    public class AddQuoteItemToQuoteHandler : IHandlerFor<AddQuoteItemToQuoteCommand>
    {
        private readonly IQuoteRepository _quoteRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBus _bus;
        public AddQuoteItemToQuoteHandler(IQuoteRepository quoteRepository, IUnitOfWork unitOfWork, IBus bus)
        {
            _quoteRepository = quoteRepository;
            _unitOfWork = unitOfWork;
            _bus = bus;
        }

        public async Task Handle(AddQuoteItemToQuoteCommand message)
        {
            var quote = await _quoteRepository.GetById(message.QuoteId);
            var quoteItem = QuoteItem.Create(message.Name, message.Description, message.Total);
            quote.AddQuoteItem(quoteItem);
            await _unitOfWork.SaveChangesAsync();

            message.Id = quoteItem.Id;

            // Optional:
            var quoteItemAddedToQuoteEvent = new QuoteItemAddedToQuoteEvent
            {
                QuoteId = quote.Id,
                QuoteItemId = quoteItem.Id
            };
            await _bus.RaiseEvent(quoteItemAddedToQuoteEvent);
        }
    }
}
