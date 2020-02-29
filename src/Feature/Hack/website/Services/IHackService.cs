using Hackathon.TeamHorizon.Feature.Hack.Models;
using Hackathon.TeamHorizon.Foundation.Search.Models;

namespace Hackathon.TeamHorizon.Feature.Hack.Services
{
    public interface IHackService
    {
        IHack GetHeroItems();
        BaseSearchResultItem GetHeroImagesSearch();
        bool IsExperienceEditor { get; }
    }
}
