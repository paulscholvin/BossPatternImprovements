using System.Linq;
using DomainModel.Entities;

namespace Infrastructure.Interfaces
{
    public interface IQueryDataContext
    {
        IQueryable<Quote> Quotes { get; }
    }
}
