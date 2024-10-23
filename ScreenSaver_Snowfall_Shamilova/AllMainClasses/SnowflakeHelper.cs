using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ScreenSaver_Snowfall_Shamilova
{
    /// <summary>
    /// Помощник для управления снежинками.
    /// </summary>
    public class SnowflakeHelper
    {
        private List<Snowflake> snowflakes;
        private Texture2D image;
        private Random random;
        private GraphicsDeviceManager graphicsDevice;

        /// <summary>
        /// Инициализирует новый экземпляр класса.
        /// </summary>
        public SnowflakeHelper(Texture2D image, GraphicsDeviceManager graphicsDevice)
        {
            this.image = image;
            snowflakes = new List<Snowflake>();
            random = new Random();
            this.graphicsDevice = graphicsDevice;
        }

        /// <summary>
        /// Создание заданного количества снежинок и добавление их в список.
        /// </summary>
        public void CreateSnowflakes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var x = random.Next(graphicsDevice.PreferredBackBufferWidth);
                var y = -random.Next(graphicsDevice.PreferredBackBufferHeight);
                var size = (float)random.NextDouble() * 0.9f + 0.1f;
                var speed = CalculateSpeed(size);

                Snowflake snowflake = new Snowflake(image, new Vector2(x, y), size, speed);
                snowflakes.Add(snowflake);
            }
        }

        private float CalculateSpeed(float size)
        {
            if (size < 0.6f)
                return size * 20f;
            else
                return size * 2f;
        }

        /// <summary>
        /// Обновление положения снежинок на экране.
        /// </summary>
        public void Update(GameTime gameTime)
        {
            foreach (var snowflake in snowflakes.ToList())
            {
                var newPosition = snowflake.Position + new Vector2(0, snowflake.Speed);

                if (newPosition.Y > graphicsDevice.PreferredBackBufferHeight)
                {
                    ResetSnowflake(snowflake);
                }
                else
                {
                    snowflake.Position = newPosition;
                }
            }
        }

        private void ResetSnowflake(Snowflake snowflake)
        {
            var newX = random.Next(graphicsDevice.PreferredBackBufferWidth);
            var newY = -random.Next(100, 200);

            snowflake.Position = new Vector2(newX, newY);
        }

        /// <summary>
        /// Метод отвечает за отрисовку снежинок на экране.
        /// </summary>
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var snowflake in snowflakes)
            {
                float scale = snowflake.Size;
                spriteBatch.Draw(snowflake.Texture, snowflake.Position, null, Color.White, 0f, Vector2.Zero, scale, SpriteEffects.None, 0f);
            }
        }
    }
}