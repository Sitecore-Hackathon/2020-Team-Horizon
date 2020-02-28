using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Sitecore.Pipelines;

namespace Hackathon.TeamHorizon.Feature.Hero.Routes
{
    public class RegisterRoutes
    {
        /// <summary>
        ///     This route is NOT required for the Hero feature, it is only here as an example of how to
        ///     register a custom route. You can access it using http://{host}/ApiTest/CustomRoute/Hero/SomeParam
        ///     We can also use Sitecore native rather than a custom route http://{host}/api/sitecore/HeroAPI/TestAction
        /// </summary>
        /// <param name="args"></param>
        public void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute("Feature.Hero", "ApiTest/CustomRoute/Hero/{someParam}",
                new { controller = "HeroAPI", action = "TestAction", someParam = RouteParameter.Optional });
        }
    }
}
