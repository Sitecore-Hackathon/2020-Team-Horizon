using Glass.Mapper.Sc.Configuration.Attributes;
using System;

namespace Hackathon.TeamHorizon.Foundation.ORM.Models
{
    public interface ISitecoreId
    {
        [SitecoreId]
        Guid Id { get; set; }
    }
}
