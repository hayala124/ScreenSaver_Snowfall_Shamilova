using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ScreenSaver_Snowfall_Shamilova
{
    /// <summary>
    /// Снежинка.
    /// </summary>
    public class Snowflake
    {
        /// <summary>
        /// Текстура снежинки.
        /// </summary>
        public Texture2D Texture { get; set; }
        /// <summary>
        /// Текущее положение снежинки на экране.
        /// </summary>
        public Vector2 Position { get; set; }
        /// <summary>
        /// Размер снежинки.
        /// </summary>
        public float Size { get; set; }
        /// <summary>
        /// Скорость движения снежинки.
        /// </summary>
        public float Speed { get; set; }
        /// <summary>
        /// Инициализирует новый экземпляр класса с заданными параметрами.
        /// </summary>
        public Snowflake(Texture2D texture, Vector2 position, float size, float speed)
        {
            Texture = texture;
            Position = position;
            Size = size;
            Speed = speed;
        }
    }
}