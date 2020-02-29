using AutoFixture;
using AutoFixture.Kernel;

namespace Hackathon.TeamHorizon.Foundation.Testing.Customizations
{
    public class InterfaceImplementationCustomization<TInterface, TImplementation> : ICustomization where TImplementation : TInterface
    {
        private readonly bool _freeze;
        private readonly bool _omitAutoProperties;

        public InterfaceImplementationCustomization(bool freeze = false, bool omitAutoProperties = false)
        {
            _freeze = freeze;
            _omitAutoProperties = omitAutoProperties;
        }

        public void Customize(IFixture fixture)
        {
            if (_omitAutoProperties)
            {
                fixture.Customize<TImplementation>(c => c.OmitAutoProperties());
            }
            if (_freeze)
            {
                fixture.Freeze<TImplementation>();
            }
            fixture.Customizations.Add(new TypeRelay(typeof(TInterface), typeof(TImplementation)));
        }
    }
}
