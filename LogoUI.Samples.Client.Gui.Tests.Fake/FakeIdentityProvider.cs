using LogoUI.Samples.Client.Model.Contracts;

namespace LogoUI.Samples.Client.Gui.Tests.Fake
{
    public class FakeIdentityProvider : IIdentityProvider
    {
        public string Name { get; set; }
    }
}
