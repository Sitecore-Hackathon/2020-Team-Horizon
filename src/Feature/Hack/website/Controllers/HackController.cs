using Sitecore.Mvc.Controllers;
using System.Web.Mvc;
using Hackathon.TeamHorizon.Feature.Hack.Mediators;
using Hackathon.TeamHorizon.Foundation.Core.Exceptions;

namespace Hackathon.TeamHorizon.Feature.Hack.Controllers
{
    public class HackController : SitecoreController
    {
        private readonly IHackMediator _hackMediator;

        public HackController(IHackMediator hackMediator)
        {
            _hackMediator = hackMediator;
        }

        public ActionResult Hack()
        {
            var mediatorResponse = _hackMediator.RequestHackViewModel();

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
