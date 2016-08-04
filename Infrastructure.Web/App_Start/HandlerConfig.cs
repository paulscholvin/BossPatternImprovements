using System.Web.Http;
using Application.Handlers.Quote;
using Application.Interfaces;
using Microsoft.Practices.Unity;

namespace Infrastructure.Web.App_Start
{
    public class HandlerConfig
    {
        public static void RegisterHandlers(IBus bus)
        {
            bus.RegisterHandler<CreateQuoteHandler>();
        }
    }
}