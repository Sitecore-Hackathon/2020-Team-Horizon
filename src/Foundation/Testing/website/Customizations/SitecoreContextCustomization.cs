using Glass.Mapper.Sc;
using DependencyResolver = Glass.Mapper.Sc.IoC.DependencyResolver;
using Sitecore.FakeDb;
using AutoFixture;

namespace Hackathon.TeamHorizon.Foundation.Testing.Customizations
{
    public class SitecoreContextCustomization : ICustomization
    {
        public SitecoreContextCustomization()
        {
            var config = new Config();
            var resolver = new DependencyResolver(config);
            //resolver.Finalise();
            var context = Glass.Mapper.Context.Create(resolver);
        }

        public void Customize(IFixture fixture)
        {
            fixture.Customize<ISitecoreContext>(c => c.FromFactory<IFixture>(f => new SitecoreContext(f.Freeze<Db>().Database)));
        }
    }
}
