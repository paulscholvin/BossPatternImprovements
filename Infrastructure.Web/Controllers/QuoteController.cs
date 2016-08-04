using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using DomainModel.Entities;
using Infrastructure.Web.Dtos;
using Infrastructure.Web.QueryServices;
using Infrastructure.Web.Services;

namespace Infrastructure.Web.Controllers
{
    public class QuoteController : ApiController
    {
        private readonly IQuoteService _quoteService;
        private readonly IQuoteQueryService _quoteQueryService;

        public QuoteController(IQuoteService quoteService, IQuoteQueryService quoteQueryService)
        {
            _quoteService = quoteService;
            _quoteQueryService = quoteQueryService;
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("Quote")]
        public async Task<IEnumerable<QuoteDto>> GetAllQuotes()
        {
            return await _quoteQueryService.GetAllQuotes();
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("Quote/Create")]
        public async Task Create([FromBody]string name)
        {
            await _quoteService.CreateQuote(name);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("Quote/AddQuoteItem")]
        public async Task AddQuoteItemToQuote(QuoteItemDto dto)
        {
            await _quoteService.AddQuoteItemToQuote(dto);
        }
    }
}
