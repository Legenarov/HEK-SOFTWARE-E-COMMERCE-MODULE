using HekSoftware.Forms;
using HekSoftware.Infrastructure;

namespace HekSoftware;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        _ = StoreRepository.Instance;
        Application.Run(new LoginForm());
    }
}

