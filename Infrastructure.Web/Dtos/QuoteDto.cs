using System.Collections.Generic;

namespace Infrastructure.Web.Dtos
{
    public class QuoteDto
    {
        public string Name { get; set; }
        public IEnumerable<QuoteItemDto> QuoteItems { get; set; }
    }
}