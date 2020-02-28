using System.ComponentModel.DataAnnotations;
using Hackathon.TeamHorizon.Foundation.Core.Models;

namespace Hackathon.TeamHorizon.Foundation.Core.Services
{
    public class MediatorService : IMediatorService
    {
        public MediatorResponse<T> GetMediatorResponse<T>(string code, T viewModel = default(T),
            ValidationResult validationResult = null, object parameters = null, string message = null)
        {
            var response = new Models.MediatorResponse<T>
            {
                Code = code,
                ViewModel = viewModel,
                ValidationResult = validationResult,
                Parameters = parameters,
                Message = message
            };

            return response;
        }
    }
}
