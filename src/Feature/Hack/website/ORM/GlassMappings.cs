using Glass.Mapper.Sc.Maps;
using Hackathon.TeamHorizon.Feature.Hack.Models;

namespace Hackathon.TeamHorizon.Feature.Hack.ORM
{
    public class GlassMappings : SitecoreGlassMap<IHack>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
                config.TemplateId(Constants.Hack.TemplateId);
                config.Field(f => f.HackTitle).FieldName("Hack Title");
                config.Field(f => f.HackImage).FieldName("Hack Image");
                config.Field(f => f.HackBody).FieldName("Hack Body");
                config.Field(f => f.TeamTitle).FieldName("Team Title");
                config.Field(f => f.TeamCountry).FieldName("Team Country");
                config.Field(f => f.TeamCity).FieldName("Team City");
                config.Field(f => f.TeamDetails).FieldName("Team Details");
            });
        }
    }

    public class GlassBaseMappings : SitecoreGlassMap<IHackGlassBase>
    {
        public override void Configure()
        {
            Map(config =>
            {
                config.AutoMap();
            });
        }
    }
}
