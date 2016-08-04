using System.Collections.Generic;
using System.Threading.Tasks;
using DomainModel.Entities;
using Infrastructure.Web.Dtos;

namespace Infrastructure.Web.QueryServices
{
    public interface IQuoteQueryService
    {
        Task<IEnumerable<QuoteDto>> GetAllQuotes();
    }
}
