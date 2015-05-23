using System.ComponentModel.Composition;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoUI.Samples.Client.Model.Providers.Contracts;
using Solid.Practices.Modularity;

namespace LogoUI.Samples.Client.Model.Providers.Fake
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
