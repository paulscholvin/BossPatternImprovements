using DomainModel.Entities;
using DomainModel.Interfaces;

namespace Domain.Services
{
    public class QuoteFactory : IQuoteFactory
    {
        public void CreateWith(string name)
        {
            return new Quote() { }
        }
    }
}
