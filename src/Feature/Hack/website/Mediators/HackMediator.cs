using Hackathon.TeamHorizon.Feature.Hack.Factories;
using Hackathon.TeamHorizon.Feature.Hack.Services;
using Hackathon.TeamHorizon.Feature.Hack.ViewModels;
using Hackathon.TeamHorizon.Foundation.Core.Models;
using Hackathon.TeamHorizon.Foundation.Core.Services;

namespace Hackathon.TeamHorizon.Feature.Hack.Mediators
{
    public class HackMediator : IHackMediator
    {
        private readonly IHackService _hackService;
        private readonly IMediatorService _mediatorService;
        private readonly IHackViewModelFactory _hackViewModelFactory;

        public HackMediator(IHackService hackService, IMediatorService mediatorService,
            IHackViewModelFactory hackViewModelFactory)
        {
            _hackService = hackService;
            _mediatorService = mediatorService;
            _hackViewModelFactory = hackViewModelFactory;
        }

        /// <summary>
        ///     Mediator pattern is overkill in this instance, but here as an example to return response codes to a controller, and
        ///     keep the controller dumb as a result
        /// </summary>
        /// <returns>A mediator response with the result of the view model instantiation</returns>
        public MediatorResponse<HackViewModel> RequestHackViewModel()
        {
            var hackItemDataSource = _hackService.GetHackItems();

            if (hackItemDataSource == null)
                return _mediatorService.GetMediatorResponse<HackViewModel>(MediatorCodes.HackResponse.DataSourceError);

            var viewModel =
                _hackViewModelFactory.CreateHeroViewModel(hackItemDataSource, _hackService.IsExperienceEditor);

            if (viewModel == null)
                return _mediatorService.GetMediatorResponse<HackViewModel>(MediatorCodes.HackResponse.ViewModelError);

            return _mediatorService.GetMediatorResponse(MediatorCodes.HackResponse.Ok, viewModel);
        }
    }
}
