namespace LogoUI.Samples.Client.Providers.Contracts
{
    public interface ILoginProvider
    {
        void Login(string userName, string password);
        void Logout(string userName);
    }
}
