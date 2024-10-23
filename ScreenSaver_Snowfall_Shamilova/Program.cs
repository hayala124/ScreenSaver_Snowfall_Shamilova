namespace ScreenSaver_Snowfall_Shamilova
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Screen screen = new Screen())
            {
                screen.Run();
            }
        }
    }
}
