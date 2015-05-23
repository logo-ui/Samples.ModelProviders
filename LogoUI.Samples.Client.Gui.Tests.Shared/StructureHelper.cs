using Caliburn.Micro;
using LogoUI.Samples.Client.Gui.Shell.ViewModels;

namespace LogoUI.Samples.Gui.Tests.Shared
{
    public static class StructureHelper
    {
        private static ShellViewModel _rootObject;

        public static void SetRootObject(object rootObject)
        {
            _rootObject = (ShellViewModel) rootObject;
        }

        public static LoginViewModel GetLogin()
        {
            return (LoginViewModel)GetShellActiveItemInternal();
        }

        public static IScreen GetShellActiveItem()
        {
            return GetShellActiveItemInternal();
        }        

        public static ShellViewModel GetShell()
        {
            return GetShellInternal();
        }

        private static ShellViewModel GetShellInternal()
        {
            return _rootObject;
        }

        private static IScreen GetShellActiveItemInternal()
        {
            return (GetShellInternal()).ActiveItem;
        }
    }
}
