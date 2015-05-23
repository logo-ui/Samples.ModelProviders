using LogoUI.Samples.Client.Model.Contracts;

namespace LogoUI.Samples.Client.Model.Shared
{
    public class IdentityContext
    {
        private static IIdentityProvider _current = new DefaultIdentityProvider();
        public static IIdentityProvider Current
        {
            get { return _current; }
            set { _current = value; }
        }
    }
}
