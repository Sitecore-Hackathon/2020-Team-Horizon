using Hackathon.TeamHorizon.Foundation.ORM.Models;

namespace Hackathon.TeamHorizon.Feature.Hack.Models
{
    // Use a Glass Base item for all Modules for infer types and to avoid 'Type Hijacking'
    public interface IHackGlassBase : IGlassBase
    {
    }
}
