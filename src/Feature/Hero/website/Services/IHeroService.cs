using Hackathon.TeamHorizon.Feature.Hero.Models;
using Hackathon.TeamHorizon.Foundation.Search.Models;

namespace Hackathon.TeamHorizon.Feature.Hero.Services
{
    public interface IHeroService
    {
        IHero GetHeroItems();
        BaseSearchResultItem GetHeroImagesSearch();
        bool IsExperienceEditor { get; }
    }
}
