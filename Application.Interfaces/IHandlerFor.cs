using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IHandlerFor<in T> where T : IMessage
    {
        Task Handle(T message);
    }
}
