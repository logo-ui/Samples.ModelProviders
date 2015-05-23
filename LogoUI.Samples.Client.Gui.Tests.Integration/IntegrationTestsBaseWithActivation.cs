using Attest.Fake.Moq;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoFX.UI.Tests.NUnit;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using LogoUI.Samples.Gui.Tests.Shared;

namespace LogoUI.Samples.Gui.Tests.Integration
{
    public abstract class IntegrationTestsBaseWithActivation : TestsBaseWithActivation<ExtendedSimpleIocContainer, FakeFactory, ShellViewModel, TestBootstrapper>
    {        
    }
}
