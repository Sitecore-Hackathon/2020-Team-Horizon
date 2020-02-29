using Hackathon.TeamHorizon.Feature.Hack.Models;
using Hackathon.TeamHorizon.Feature.Hack.ViewModels;

namespace Hackathon.TeamHorizon.Feature.Hack.Factories
{
    public interface IHackViewModelFactory
    {
        HackViewModel CreateHeroViewModel(IHack hackItemDataSource, bool isExperienceEditor);
    }
}
