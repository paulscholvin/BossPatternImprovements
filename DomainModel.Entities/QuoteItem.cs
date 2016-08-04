using System;

namespace DomainModel.Entities
{
    public class QuoteItem : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Total { get; private set; }

        public int QuoteId { get; private set; }
        public Quote Quote { get; private set; }

        protected QuoteItem()
        { }

        public static QuoteItem Create(string name, string description, decimal total)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required", nameof(name));
            if (total<= 0)
                throw new ArgumentException("Total must be greater that 0", nameof(total));

            return new QuoteItem
            {
                Name = name,
                Description = description,
                Total = total
            };
        }
    }
}
