using System.Linq;
using Attest.Fake.Moq;
using Attest.Tests.Specflow;
using LogoUI.Samples.Client.Builders;
using LogoUI.Samples.Client.Gui.Modularity.ViewModels;
using LogoUI.Samples.Client.Gui.Modules.Compliance.ViewModels;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;
using LogoUI.Samples.Gui.Tests.Shared;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace LogoUI.Samples.Client.Gui.Tests.Specifications.Steps
{
    [Binding]
    class ComplianceSteps : StepsBase<FakeFactory>
    {        
        [Given(@"Server returns compliance records of count (.*)")]
        public void GivenServerReturnsComplianceRecordsOfCount(int recordsCount)
        {            
            RegisterBuilder(ComplianceProviderBuilder.CreateBuilder().WithComplianceRecord(recordsCount));            
        }

        [When(@"I access the compliance screen")]
        public void WhenIAccessTheComplianceScreen()
        {
            GetComplianceRoot();            
        }        

        [Then(@"compliance screen should display compliance records of count (.*)")]
        public void ThenComplianceScreenShouldDisplayComplianceRecordsOfCount(int recordsCount)
        {            
            var moduleRootViewModel = GetComplianceRoot();
            var complianceRecords =
                moduleRootViewModel.ConsoleViewModel.ListViewModel.Items.OfType<ComplianceRecordViewModel>();
            Assert.AreEqual(recordsCount, complianceRecords.Count());            
        }

        private static ComplianceRootViewModel GetComplianceRoot()
        {
            var mainViewModel = (MainViewModel)StructureHelper.GetShellActiveItem();
            var firstModule = mainViewModel.Modules.OfType<ModuleViewModel>().First(t => t.Name == "Compliance");
            return (ComplianceRootViewModel)(firstModule.RootViewModel);
        }

    }
}
