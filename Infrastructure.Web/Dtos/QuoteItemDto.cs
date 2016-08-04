namespace Infrastructure.Web.Dtos
{
    public class QuoteItemDto
    {
        public int QuoteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
    }
}