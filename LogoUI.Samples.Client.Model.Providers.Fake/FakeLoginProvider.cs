using System.Security;
using LogoUI.Samples.Client.Model.Providers.Contracts;

namespace LogoUI.Samples.Client.Model.Providers.Fake
{
    class FakeLoginProvider : ILoginProvider
    {
        public void Login(string userName, string password)
        {
            if (userName == "e")
            {
                throw new SecurityException("Unauthorized credentials");
            }
        }

        public void Logout(string userName)
        {
            
        }
    }
}
