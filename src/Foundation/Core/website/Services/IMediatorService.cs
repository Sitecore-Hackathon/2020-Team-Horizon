using System.ComponentModel.DataAnnotations;
using Hackathon.TeamHorizon.Foundation.Core.Models;

namespace Hackathon.TeamHorizon.Foundation.Core.Services
{
    public interface IMediatorService
    {
        MediatorResponse<T> GetMediatorResponse<T>(string code, T viewModel = default(T),
            ValidationResult validationResult = null, object parameters = null, string message = null);
    }
}
