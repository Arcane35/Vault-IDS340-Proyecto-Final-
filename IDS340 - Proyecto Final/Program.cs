namespace Vault_IDS340_Proyecto_Final
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormPrincipal());
        }
    }
}