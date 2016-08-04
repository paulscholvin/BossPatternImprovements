using DomainModel.Entities;

namespace Infrastructure.DataAccess.Mappings
{
    public class QuoteItemMap : EntityMapBase<QuoteItem>
    {
        public QuoteItemMap()
        {
            Property(qi => qi.Name).IsRequired();
            Property(qi => qi.Description).IsOptional();
            Property(qi => qi.Total).IsRequired();

            HasRequired(qi => qi.Quote).WithMany(q => q.QuoteItems).HasForeignKey(qi => qi.QuoteId);
        }
    }
}
