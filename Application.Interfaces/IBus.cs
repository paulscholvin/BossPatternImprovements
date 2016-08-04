using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IBus
    {
        void RegisterHandler<T>() where T: class;
        Task Send<T>(T command) where T : ICommand;
        Task RaiseEvent<T>(T theEvent) where T: IEvent;
    }
}
