using System.Security.Principal;
using LogoUI.Samples.Client.Model.Contracts;

namespace LogoUI.Samples.Client.Model.Shared
{
    class DefaultIdentityProvider : IIdentityProvider
    {
        public string Name
        {
            get
            {
                var accountToken = WindowsIdentity.GetCurrent();
                if (accountToken != null && accountToken.IsAuthenticated)
                    return accountToken.Name;
                return null;
            }
        }
    }
}