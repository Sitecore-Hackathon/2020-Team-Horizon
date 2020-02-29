using System.Collections.Generic;
using System.Web;
using Glass.Mapper.Sc.Fields;

namespace Hackathon.TeamHorizon.Feature.Hack.ViewModels
{
    public class HackViewModel
    {
        public HtmlString HackTitle { get; set; }
        public HtmlString HackBody { get; set; }
        public HtmlString TeamTitle { get; set; }
        public HtmlString TeamCountry { get; set; }
        public HtmlString TeamCity { get; set; }
        public HtmlString TeamDetails { get; set; }
        public Image HackImage { get; set; }
        public bool IsExperienceEditor { get; set; }
    }
}
