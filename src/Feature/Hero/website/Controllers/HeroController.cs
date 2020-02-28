using Sitecore.Mvc.Controllers;
using System.Web.Mvc;
using Hackathon.TeamHorizon.Feature.Hero.Mediators;
using Hackathon.TeamHorizon.Foundation.Core.Exceptions;

namespace Hackathon.TeamHorizon.Feature.Hero.Controllers
{
    public class HeroController : SitecoreController
    {
        private readonly IHeroMediator _heroMediator;

        public HeroController(IHeroMediator heroMediator)
        {
            _heroMediator = heroMediator;
        }

        public ActionResult Hero()
        {
            var mediatorResponse = _heroMediator.RequestHeroViewModel();

            switch (mediatorResponse.Code)
            {
                case MediatorCodes.HeroResponse.DataSourceError:
                case MediatorCodes.HeroResponse.ViewModelError:
                    return View("~/views/Hero/Error.cshtml");
                case MediatorCodes.HeroResponse.Ok:
                    return View(mediatorResponse.ViewModel);
                default:
                    throw new InvalidMediatorResponseCodeException(mediatorResponse.Code);
            }
        }
    }
}
