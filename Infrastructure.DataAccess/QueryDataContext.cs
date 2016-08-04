using System.Linq;
using DomainModel.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.DataAccess
{
    public class QueryDataContext : IQueryDataContext
    {
        private readonly IDataContext _dataContext;

        public QueryDataContext(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IQueryable<Quote> Quotes => _dataContext.Quotes.AsQueryable();
    }
}
