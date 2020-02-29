using System.Web;

namespace Hackathon.TeamHorizon.Foundation.Testing.TestDoubles.External
{
    internal class HttpContextStub : HttpContextBase
    {
        public override HttpServerUtilityBase Server => new HttpServerUtilityStub();

        private class HttpServerUtilityStub : HttpServerUtilityBase
        {
            public override string MapPath(string path) => path;
        }
    }
}