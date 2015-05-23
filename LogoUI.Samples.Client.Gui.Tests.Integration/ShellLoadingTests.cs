using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using LogoUI.Samples.Gui.Tests.Shared;
using NUnit.Framework;

namespace LogoUI.Samples.Gui.Tests.Integration
{
    [TestFixture]
    [Category("Integration")]
    public class ShellLoadingTests : IntegrationTestsBaseWithActivation
    {        
        [Test]
        public void Initialization_DoesNotThrow()
        {           
            Assert.DoesNotThrow(() => CreateRootObject());
        }

        [Test]
        public void Initialization_LoginScreenIsActive()
        {
            var rootObject = CreateRootObject();
            StructureHelper.SetRootObject(rootObject);

            var activeItem = StructureHelper.GetShellActiveItem();
            Assert.IsInstanceOf<LoginViewModel>(activeItem);
        }
    }
}
