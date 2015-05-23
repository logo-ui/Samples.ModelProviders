using LogoUI.Samples.Client.Model.Contracts.UserManagement;

namespace LogoUI.Samples.Client.Model.UserManagement
{
    public sealed class LocalUser : UserBase, ILocalUser
    {
        public bool IsAdmin { get; set; }
    }
}
