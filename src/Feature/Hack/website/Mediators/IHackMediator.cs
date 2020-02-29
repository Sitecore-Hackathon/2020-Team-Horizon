using Hackathon.TeamHorizon.Feature.Hack.ViewModels;
using Hackathon.TeamHorizon.Foundation.Core.Models;

namespace Hackathon.TeamHorizon.Feature.Hack.Mediators
{
    public interface IHackMediator
    {
        MediatorResponse<HackViewModel> RequestHackViewModel();
    }
}
