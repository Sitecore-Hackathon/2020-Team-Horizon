using Hackathon.TeamHorizon.Feature.Hack.Models;
using Hackathon.TeamHorizon.Foundation.Content.Repositories;
using Hackathon.TeamHorizon.Foundation.Logging.Repositories;

namespace Hackathon.TeamHorizon.Feature.Hack.Services
{
    public class HackService : IHackService
    {
        private readonly IContextRepository _contextRepository;
        private readonly ILogRepository _logRepository;
        private readonly IRenderingRepository _renderingRepository;

        public HackService(IContextRepository contextRepository,
            ILogRepository logRepository, IRenderingRepository renderingRepository)
        {
            _contextRepository = contextRepository;
            _logRepository = logRepository;
            _renderingRepository = renderingRepository;
        }

        /// <summary>
        ///     Get an item using the rendering repository
        /// </summary>
        /// <returns>The Hero datasource item from the Content API</returns>
        public IHack GetHackItems()
        {
            var dataSource = _renderingRepository.GetDataSourceItem<IHack>();

            // Basic example of using the wrapped logger
            if (dataSource == null)
                _logRepository.Warn(Logging.Error.DataSourceError);

            return dataSource;
        }

        public bool IsExperienceEditor => _contextRepository.IsExperienceEditor;
    }
}
