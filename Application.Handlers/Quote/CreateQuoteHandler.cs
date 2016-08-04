using System.Threading.Tasks;
using Application.Commands;
using Application.Events;
using Application.Interfaces;
using DomainModel.Interfaces;

namespace Application.Handlers.Quote
{
    public class CreateQuoteHandler : IHandlerFor<CreateQuoteCommand>
    {
        private readonly IQuoteRepository _quoteRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBus _bus;

        public CreateQuoteHandler(IQuoteRepository quoteRepository, IUnitOfWork unitOfWork, IBus bus)
        {
            _quoteRepository = quoteRepository;
            _unitOfWork = unitOfWork;
            _bus = bus;
        }

        public async Task Handle(CreateQuoteCommand command)
        {
            var quote = DomainModel.Entities.Quote.Create(command.Name);
            _quoteRepository.Add(quote);
            await _unitOfWork.SaveChangesAsync();

            command.Id = quote.Id;

            // optional
            var quoteCreatedEvent = new QuoteCreatedEvent
            {
                Id = quote.Id
            };
            await _bus.RaiseEvent(quoteCreatedEvent);
        }
    }
}
