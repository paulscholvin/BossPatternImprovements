using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Handlers.Quote;
using Application.Interfaces;
using Microsoft.Practices.Unity;

namespace Infrastructure.Bus
{
    public class InMemoryBus : IBus
    {
        private static readonly IList<Type> RegisteredHandlers = new List<Type>();

        private readonly IUnityContainer _unityContainer;

        public InMemoryBus(IUnityContainer unityContainer)
        {
            _unityContainer = unityContainer;
            RegisterHandler<CreateQuoteHandler>();
            RegisterHandler<AddQuoteItemToQuoteHandler>();
        }

        public void RegisterHandler<T>() where T : class
        {
            RegisteredHandlers.Add(typeof(T));
        }

        public async Task Send<T>(T command) where T : ICommand
        {
            var openInterface = typeof(IHandlerFor<>);
            var closedInterface = openInterface.MakeGenericType(command.GetType());
            var handlerTypes = RegisteredHandlers.Where(h => closedInterface.IsAssignableFrom(h));
            foreach (var handlerType in handlerTypes)
            {
                var instance = (IHandlerFor<T>)_unityContainer.Resolve(handlerType);
                await instance.Handle(command);
            }
        }

        public async Task RaiseEvent<T>(T theEvent) where T : IEvent
        {
            await Task.FromResult(true);
        }
    }
}
