namespace LogoUI.Samples.Client.Model.Providers.Contracts
{
    public interface ILoginProvider
    {
        void Login(string userName, string password);
        void Logout(string userName);
    }
}
