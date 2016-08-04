using Application.Interfaces;

namespace Application.Commands
{
    public class CreateQuoteCommand : ICommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
