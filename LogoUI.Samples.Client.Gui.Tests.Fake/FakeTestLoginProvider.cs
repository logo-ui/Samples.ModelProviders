using System.Security;
using LogoUI.Samples.Client.Providers.Contracts;

namespace LogoUI.Samples.Client.Gui.Tests.Fake
{
    public class FakeTestLoginProvider : ILoginProvider
    {
        private bool _isLoginSuccess;

        public void Login(string userName, string password)
        {
            if (_isLoginSuccess == false)
            {
              throw new SecurityException("Login failed");   
            }
        }

        public void Logout(string userName)
        {

        }

        public void SetupLoginSuccess()
        {
            _isLoginSuccess = true;
        }

        public void SetupLoginFailure()
        {
            _isLoginSuccess = false;
        }
    }
}
