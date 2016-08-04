using System.Data.Entity;
using DomainModel.Entities;

namespace Infrastructure.Interfaces
{
    public interface IDataContext
    {
        IDbSet<Quote> Quotes { get; }
    }
}
