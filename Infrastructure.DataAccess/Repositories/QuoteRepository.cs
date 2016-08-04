using System.Data.Entity;
using System.Threading.Tasks;
using DomainModel.Entities;
using DomainModel.Interfaces;
using Infrastructure.Interfaces;

namespace Infrastructure.DataAccess
{
    public class QuoteRepository : IQuoteRepository
    {
        private readonly IDataContext _dataContext;

        public QuoteRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(Quote entity)
        {
            _dataContext.Quotes.Add(entity);
        }

        public async Task<Quote> GetById(int id)
        {
            return await _dataContext.Quotes.Include(q => q.QuoteItems).FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
