using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using AutoMapper;
using DomainModel.Entities;
using Infrastructure.Interfaces;
using Infrastructure.Web.Dtos;

namespace Infrastructure.Web.QueryServices
{
    public class QuoteQueryService : IQuoteQueryService
    {
        private readonly IQueryDataContext _queryDataContext;
        public QuoteQueryService(IQueryDataContext queryDataContext)
        {
            _queryDataContext = queryDataContext;
        }

        public async Task<IEnumerable<QuoteDto>> GetAllQuotes()
        {
            var quotes = await _queryDataContext.Quotes.Include(q => q.QuoteItems).ToListAsync();
            return Mapper.Map<IEnumerable<Quote>, IEnumerable<QuoteDto>>(quotes);
        }
    }
}