using Glass.Mapper.Sc.Pipelines.AddMaps;
using Hackathon.TeamHorizon.Foundation.ORM.Extensions;

namespace Hackathon.TeamHorizon.Foundation.ORM.Mappings
{
    public class RegisterMappings : AddMapsPipeline  {
        public void Process(AddMapsPipelineArgs args)
        {
            args.MapsConfigFactory.AddFluentMaps("Hackathon.TeamHorizon.Foundation.ORM");
        }
    }
}
