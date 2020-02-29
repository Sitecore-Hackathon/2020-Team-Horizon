using System;

namespace Hackathon.TeamHorizon.Feature.Hack
{
    /// <summary>
    /// https://staticreadonly.com/2019/02/06/structures-vs-static-classes-for-sitecore-template-references/
    /// </summary>
    public static class Constants
    {
        public static class Hack
        {
            public static readonly Guid TemplateId = new Guid("{55C817C9-6226-460B-B015-282776C95ED0}");
        }
    }

    public static class Logging
    {
        public static class Error
        {
            public const string DataSourceError = "The Hack datasource was empty";
        }
    }

    public static class MediatorCodes
    {
        public static class HackResponse
        {
            public const string DataSourceError = "HackMediator.CreateHackViewModel.DataSourceError";
            public const string ViewModelError = "HackMediator.CreateHackViewModel.ViewModelError";
            public const string Ok = "HackMediator.CreateHackViewModel.Ok";
        }
    }
}
