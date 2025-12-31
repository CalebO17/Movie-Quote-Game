namespace PersonalProject
{
    internal static class Program
    {
        public static TitleScreen TitleScreenInstance; // Single instance

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Create one instance of TitleScreen
            TitleScreenInstance = new TitleScreen();

            // Start the app with this form
            Application.Run(TitleScreenInstance);
        }
    }
}
