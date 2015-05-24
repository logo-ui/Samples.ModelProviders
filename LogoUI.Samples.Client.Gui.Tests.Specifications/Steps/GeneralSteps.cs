using Attest.Tests.Specflow;
using Caliburn.Micro;
using LogoUI.Samples.Gui.Tests.Shared;
using TechTalk.SpecFlow;

namespace LogoUI.Samples.Client.Gui.Tests.Specifications.Steps
{
    [Binding]
    class GeneralSteps
    {
        [When(@"I open the application")]
        public void WhenIOpenTheApplication()
        {
            ScenarioHelper.CreateRootObject();
            StructureHelper.SetRootObject(ScenarioHelper.RootObject);
            ScreenExtensions.TryActivate(ScenarioHelper.RootObject);
        }
    }
}
