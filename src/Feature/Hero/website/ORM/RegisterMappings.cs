using Glass.Mapper.Sc.Pipelines.AddMaps;
using Hackathon.TeamHorizon.Foundation.ORM.Extensions;

namespace Hackathon.TeamHorizon.Feature.Hero.ORM
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("Hackathon.TeamHorizon.Feature.Hero");
        }
    }
}
