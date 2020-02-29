using Hackathon.TeamHorizon.Foundation.Testing.TestDoubles.External;
using System.Web.Mvc;
using System.Web.Routing;
using AutoFixture;
using Sitecore.Mvc.Controllers;

namespace Hackathon.TeamHorizon.Foundation.Testing.Customizations
{
    public class ControllerCustomization<TController> : ICustomization where TController : SitecoreController
    {
        public void Customize(IFixture fixture)
        {
            var routes = new RouteCollection();

            var httpContext = new HttpContextStub();

            fixture.Customize<TController>(c => c
                .With(controller => controller.ControllerContext, new ControllerContext() { HttpContext = httpContext })
                .With(controller => controller.Url, new UrlHelper(new RequestContext(httpContext, new RouteData()), routes))
                .OmitAutoProperties());
        }
    }
}
