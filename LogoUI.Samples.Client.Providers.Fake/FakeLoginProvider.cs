using System.Security;
using LogoUI.Samples.Client.Providers.Contracts;

namespace LogoUI.Samples.Client.Providers.Fake
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
