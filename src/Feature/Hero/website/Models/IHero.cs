using System.Collections.Generic;
using Glass.Mapper.Sc.Fields;

namespace Hackathon.TeamHorizon.Feature.Hero.Models
{
    public interface IHero : IHeroGlassBase
    {
        string HeroTitle { get; set; }
        IEnumerable<Image> HeroImages { get; set; }
    }
}
