using System.Threading.Tasks;
using Infrastructure.Web.Dtos;

namespace Infrastructure.Web.Services
{
    public interface IQuoteService
    {
        Task CreateQuote(string name);
        Task AddQuoteItemToQuote(QuoteItemDto dto);
    }
}
