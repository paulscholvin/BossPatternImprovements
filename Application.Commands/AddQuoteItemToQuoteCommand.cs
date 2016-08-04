using Application.Interfaces;
using ICommand = Application.Interfaces.ICommand;

namespace Application.Commands
{
    public class AddQuoteItemToQuoteCommand : ICommand
    {
        public int QuoteId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Total { get; set; }
    }
}
