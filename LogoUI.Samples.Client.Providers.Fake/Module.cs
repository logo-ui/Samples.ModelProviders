using System.ComponentModel.Composition;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoUI.Samples.Client.Providers.Contracts;
using Solid.Practices.Modularity;

namespace LogoUI.Samples.Client.Providers.Fake
{
    [Export(typeof(ICompositionModule))]
    public class Module : ICompositionModule<ExtendedSimpleIocContainer>
    {
        public void RegisterModule(ExtendedSimpleIocContainer container)
        {
            container.RegisterSingleton<ILoginProvider, FakeLoginProvider>();
            container.RegisterTransient<IComplianceProvider, FakeComplianceProvider>();
        }
    }
}
