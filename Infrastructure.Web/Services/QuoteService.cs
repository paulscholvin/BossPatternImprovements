using System.Threading.Tasks;
using Application.Commands;
using Application.Interfaces;
using Infrastructure.Web.Dtos;

namespace Infrastructure.Web.Services
{
    public class QuoteService : IQuoteService
    {
        private readonly IBus _bus;

        public QuoteService(IBus bus)
        {
            _bus = bus;
        }

        public async Task CreateQuote(string name)
        {
            var command = new CreateQuoteCommand
            {
                Name = name
            };
            await _bus.Send(command);
        }

        public async Task AddQuoteItemToQuote(QuoteItemDto dto)
        {
            var command = new AddQuoteItemToQuoteCommand
            {
                QuoteId = dto.QuoteId,
                Name = dto.Name,
                Description = dto.Description,
                Total = dto.Total
            };
            await _bus.Send(command);
        }
    }
}