using Hackathon.TeamHorizon.Foundation.ORM.Models;

namespace Hackathon.TeamHorizon.Foundation.Content.Tests.Models
{
    public interface ITestItem : IGlassBase
    {
        string Title { get; set; }
    }
}
