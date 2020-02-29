using Hackathon.TeamHorizon.Feature.Hero.ViewModels;
using Hackathon.TeamHorizon.Foundation.Core.Models;

namespace Hackathon.TeamHorizon.Feature.Hero.Mediators
{
    public interface IHeroMediator
    {
        MediatorResponse<HeroViewModel> RequestHeroViewModel();
    }
}
