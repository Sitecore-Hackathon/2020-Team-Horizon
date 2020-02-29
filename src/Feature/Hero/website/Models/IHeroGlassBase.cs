using Hackathon.TeamHorizon.Foundation.ORM.Models;

namespace Hackathon.TeamHorizon.Feature.Hero.Models
{
    // Use a Glass Base item for all Modules for infer types and to avoid 'Type Hijacking'
    public interface IHeroGlassBase : IGlassBase
    {
    }
}
