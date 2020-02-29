using System.Web;
using Glass.Mapper.Sc;
using Hackathon.TeamHorizon.Feature.Hero.Models;
using Hackathon.TeamHorizon.Feature.Hero.ViewModels;

namespace Hackathon.TeamHorizon.Feature.Hero.Factories
{
    public class HeroViewModelFactory : IHeroViewModelFactory
    {
        private readonly IGlassHtml _glassHtml;

        public HeroViewModelFactory(IGlassHtml glassHtml)
        {
            _glassHtml = glassHtml;
        }

        public HeroViewModel CreateHeroViewModel(IHero heroItemDataSource, bool isExperienceEditor)
        {
            return new HeroViewModel
            {
                HeroImages = heroItemDataSource.HeroImages,
                HeroTitle = new HtmlString(_glassHtml.Editable(heroItemDataSource, i => i.HeroTitle,
                    new { EnclosingTag = "h2" })),
                HeroBody = new HtmlString(_glassHtml.Editable(heroItemDataSource, i => i.HeroBody, new { EnclosingTag = "div" })),
                IsExperienceEditor = isExperienceEditor
            };
        }
    }
}
