using System;
using System.Collections.Generic;

namespace DomainModel.Entities
{
    public class Quote : Entity
    {
        public string Name { get; private set; }
        public virtual ICollection<QuoteItem> QuoteItems { get; protected set; }

        protected Quote()
        { }

        public static Quote Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is required", nameof(Name));

            return new Quote
            {
                Name = name
            };
        }

        public void AddQuoteItem(QuoteItem quoteItem)
        {
            if (quoteItem.Id > 0)
                throw new ArgumentException("The QuoteItem must be new", nameof(quoteItem));

            QuoteItems.Add(quoteItem);
        }
    }
}
