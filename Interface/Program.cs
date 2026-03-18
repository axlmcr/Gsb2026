using Metier;

namespace Interface
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Session? session = FrmConnexion.getSession();
                if (session is not null)
                {
                    Application.Run(new FrmMenu(session));
                }
                // sinon, l'utilisateur a annulé la connexion : on quitte l'application
            } catch (OperationCanceledException)
            {
                // L'utilisateur a fermé le formulaire de connexion
                Application.Exit();
            }
        }
    }
}
