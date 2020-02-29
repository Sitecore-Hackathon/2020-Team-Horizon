using Hackathon.TeamHorizon.Feature.Hack.Factories;
using Hackathon.TeamHorizon.Feature.Hack.Mediators;
using Hackathon.TeamHorizon.Feature.Hack.Services;
using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;

namespace Hackathon.TeamHorizon.Feature.Hack.DI
{
    public class RegisterContainer : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IHackMediator, HackMediator>();
            serviceCollection.AddTransient<IHackService, HackService>();
            serviceCollection.AddTransient<IHackViewModelFactory, HackViewModelFactory>();
        }
    }
}
