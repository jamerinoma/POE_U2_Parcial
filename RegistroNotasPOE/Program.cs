using RepoDb;
using RegistroNotasPOE.Formularios;

namespace RegistroNotasPOE;
internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        GlobalConfiguration.Setup().UseSqlServer();
        Application.Run(new frmRegistrarNota());
    }
}
