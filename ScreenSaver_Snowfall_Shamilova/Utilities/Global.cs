using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ScreenSaver_Snowfall_Shamilova
{
    static class Global
    {
        public static Screen screen;
        public static Random random = new Random();
        public static string levelName;

        public static void Initialize(Screen inputGame)
        {
            screen = inputGame;
        }
    }
}
