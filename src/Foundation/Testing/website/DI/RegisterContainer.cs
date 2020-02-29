using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Hackathon.TeamHorizon.Foundation.Testing.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            //serviceCollection.AddTransient<ILogRepository, LogRepository>();
        }
    }
}
