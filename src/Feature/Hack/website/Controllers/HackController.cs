using Sitecore.Mvc.Controllers;
using System.Web.Mvc;
using Hackathon.TeamHorizon.Feature.Hack.Mediators;
using Hackathon.TeamHorizon.Foundation.Core.Exceptions;

namespace Hackathon.TeamHorizon.Feature.Hack.Controllers
{
    public class HackController : SitecoreController
    {
        private readonly IHackMediator _heroMediator;

        public HackController(IHackMediator heroMediator)
        {
            _heroMediator = heroMediator;
        }

        public ActionResult Hero()
        {
            var mediatorResponse = _heroMediator.RequestHackViewModel();

            switch (mediatorResponse.Code)
            {
                case MediatorCodes.HackResponse.DataSourceError:
                case MediatorCodes.HackResponse.ViewModelError:
                    return View("~/views/Hack/Error.cshtml");
                case MediatorCodes.HackResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }
        }
    }
}
