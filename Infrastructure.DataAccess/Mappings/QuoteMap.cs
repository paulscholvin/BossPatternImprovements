using DomainModel.Entities;

namespace Infrastructure.DataAccess.Mappings
{
    public class QuoteMap : EntityMapBase<Quote>
    {
        public QuoteMap()
        {
            Property(q => q.Name).IsRequired();
        }
    }
}
