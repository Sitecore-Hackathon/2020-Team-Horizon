using System.Collections.Generic;
using Glass.Mapper.Sc.Fields;

namespace Hackathon.TeamHorizon.Feature.Hack.Models
{
    public interface IHack : IHackGlassBase
    {
        string HackTitle { get; set; }
        string HackBody { get; set; }
        Image HackImage { get; set; }
        string TeamTitle { get; set; }
        string TeamCountry { get; set; }
        string TeamCity { get; set; }
        string TeamDetails { get; set; }
    }
}
