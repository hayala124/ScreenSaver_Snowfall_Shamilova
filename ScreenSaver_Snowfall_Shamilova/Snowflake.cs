using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenSaver_Snowfall_Shamilova
{
    //public class Snowflake
    //{
    //    public Texture2D Texture { get; set; }
    //    public Vector2 Position { get; set; }
    //    public float Speed { get; set; }
    //    public float Rotation { get; set; }
    //    public float Scale { get; set; }

    //    public Snowflake(Texture2D texture, Vector2 position, float speed, float rotation, float scale)
    //    {
    //        Texture = texture;
    //        Position = position;
    //        Speed = speed;
    //        Rotation = rotation;
    //        Scale = scale;
    //    }
    //}

    public class Snowflake
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public float Speed { get; set; }
        public float Rotation { get; set; }
        public float Scale { get; set; }

        public Snowflake(Texture2D texture, Vector2 position, float speed, float rotation, float scale)
        {
            Texture = texture;
            Position = position;
            Speed = speed;
            Rotation = rotation;
            Scale = scale;
        }
    }

}
