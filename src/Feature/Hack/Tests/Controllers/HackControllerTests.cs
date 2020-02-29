using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Mvc;
using AutoFixture;
using FluentAssertions;
using Hackathon.TeamHorizon.Feature.Hack.Controllers;
using Hackathon.TeamHorizon.Feature.Hack.Mediators;
using Hackathon.TeamHorizon.Feature.Hack.ViewModels;
using Hackathon.TeamHorizon.Foundation.Core.Exceptions;
using Hackathon.TeamHorizon.Foundation.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using ErrorMessages = Hackathon.TeamHorizon.Foundation.Core.Exceptions.Constants;

namespace Hackathon.TeamHorizon.Feature.Hack.Tests.Controllers
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
    public class HackControllerTests
    {
        private HackController _controller;
        private IHackMediator _hackMediator;

        [TestInitialize]
        public void Setup()
        {
            _hackMediator = Substitute.For<IHackMediator>();

            _controller = new HackController(_hackMediator);
        }

        [TestMethod]
        public void Hack_Action_GivenDataSourceError_ReturnsErrorView()
        {
            var fixture                 = new Fixture();
            var createViewModelResponse = fixture.Build<MediatorResponse<HackViewModel>>()
                .With(x                 => x.Code, MediatorCodes.HackResponse.DataSourceError)
                .Create();

            _hackMediator.RequestHackViewModel().Returns(createViewModelResponse);

            var result = _controller.Hack() as ViewResult;

            result.ViewName.Should().Be("~/views/Hack/Error.cshtml");
        }

        [TestMethod]
        public void Hack_Action_Throws_InvalidMediatorResponseCodeException()
        {
            var fixture                 = new Fixture();
            var createViewModelResponse = fixture.Build<MediatorResponse<HackViewModel>>()
                .With(x                 => x.Code, "Unknown code")
                .Create();

            _hackMediator.RequestHackViewModel().Returns(createViewModelResponse);

            Action act = () => _controller.Hack();
            act.ShouldThrow<InvalidMediatorResponseCodeException>().Where(e =>
                e.Message.Equals(
                    $"{ErrorMessages.InvalidMediatorResponse.InvalidCodeReturned}: {createViewModelResponse.Code}"));
        }
    }
}
