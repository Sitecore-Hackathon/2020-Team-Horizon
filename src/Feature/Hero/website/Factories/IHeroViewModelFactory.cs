using Hackathon.TeamHorizon.Feature.Hero.Models;
using Hackathon.TeamHorizon.Feature.Hero.ViewModels;

namespace Hackathon.TeamHorizon.Feature.Hero.Factories
{
    public interface IHeroViewModelFactory
    {
        HeroViewModel CreateHeroViewModel(IHero heroItemDataSource, bool isExperienceEditor);
    }
}
