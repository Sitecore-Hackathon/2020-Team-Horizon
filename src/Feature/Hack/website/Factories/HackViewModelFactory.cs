using System.Web;
using Glass.Mapper.Sc;
using Hackathon.TeamHorizon.Feature.Hack.Models;
using Hackathon.TeamHorizon.Feature.Hack.ViewModels;

namespace Hackathon.TeamHorizon.Feature.Hack.Factories
{
    public class HackViewModelFactory : IHackViewModelFactory
    {
        private readonly IGlassHtml _glassHtml;

        public HackViewModelFactory(IGlassHtml glassHtml)
        {
            _glassHtml = glassHtml;
        }

        public HackViewModel CreateHeroViewModel(IHack hackItemDataSource, bool isExperienceEditor)
        {
            return new HackViewModel
            {
                HackImage              = hackItemDataSource.HackImage,
                HackTitle              = new HtmlString(_glassHtml.Editable(hackItemDataSource, i => i.HackTitle,
                    new { EnclosingTag = "h2" })),                
                HackBody               = new HtmlString(_glassHtml.Editable(hackItemDataSource, i => i.HackBody,
                    new { EnclosingTag = "div" })),
                TeamTitle              = new HtmlString(_glassHtml.Editable(hackItemDataSource, i => i.TeamTitle,
                    new { EnclosingTag = "h2" })),
                TeamCountry            = new HtmlString(_glassHtml.Editable(hackItemDataSource, i => i.TeamCountry,
                    new { EnclosingTag = "p" })),
                TeamCity               = new HtmlString(_glassHtml.Editable(hackItemDataSource, i => i.TeamCity,
                    new { EnclosingTag = "p" })),
                TeamDetails            = new HtmlString(_glassHtml.Editable(hackItemDataSource, i => i.TeamDetails,
                    new { EnclosingTag = "div" })),
                IsExperienceEditor     = isExperienceEditor
            };
        }
    }
}
