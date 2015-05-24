using Attest.Fake.Moq;
using LogoFX.UI.Bootstrapping.SimpleContainer;
using LogoFX.UI.Tests.Specflow;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using LogoUI.Samples.Gui.Tests.Shared;

namespace LogoUI.Samples.Client.Gui.Tests.Specifications
{
    public abstract class IntegrationTestsBase : TestsBase<ExtendedSimpleIocContainer, FakeFactory, ShellViewModel, TestBootstrapper>
    {
    }
}