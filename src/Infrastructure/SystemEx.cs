namespace HW.Infrastructure
{
    using System.Security.Principal;

    static class SystemEx
    {
        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
