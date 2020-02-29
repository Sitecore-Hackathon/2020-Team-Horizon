using Hackathon.TeamHorizon.Foundation.DI.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Hackathon.TeamHorizon.Foundation.DI
{
    public class RegisterControllers : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddMvcControllers(
                "Hackathon.TeamHorizon.Feature.*");
        }
    }
}
