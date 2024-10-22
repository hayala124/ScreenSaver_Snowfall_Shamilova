using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
