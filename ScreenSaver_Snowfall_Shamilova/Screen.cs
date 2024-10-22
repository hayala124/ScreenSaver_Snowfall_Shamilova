using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace ScreenSaver_Snowfall_Shamilova
{
    public class Screen : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Timer timer;
        Texture2D image;
        Texture2D backgroundTexture;
        Vector2 position;


        public Screen() //This is the constructor, this function is called whenever the game class is created.
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.IsFullScreen = false;
            graphics.ApplyChanges();
        }

        /// <summary>
        /// This function is automatically called when the game launches to initialize any non-graphic variables.
        /// </summary>
        protected override void Initialize()
        {
            position = new Vector2(0, 0);
            base.Initialize();
        }

        /// <summary>
        /// Automatically called when your game launches to load any game assets (graphics, audio etc.)
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            image = TextureLoader.Load("snowflake", Content);
            backgroundTexture = TextureLoader.Load("forest", Content);
        }

        /// <summary>
        /// Called each frame to update the game. Games usually runs 60 frames per second.
        /// Each frame the Update function will run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        protected override void Update(GameTime gameTime)
        {
            //Input.Update();
            //if (IsImageOutsideScreen(image))

                //Update the things FNA handles for us underneath the hood:
                base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game is ready to draw to the screen, it's also called each frame.
        /// </summary>
        protected override void Draw(GameTime gameTime)
        {
            //This will clear what's on the screen each frame, if we don't clear the screen will look like a mess:
            GraphicsDevice.Clear(Color.Transparent);

            spriteBatch.Begin();
            //spriteBatch.Draw(image, position, Color.Black);
            spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            spriteBatch.Draw(image, position, Color.White);

            spriteBatch.End();
            //Draw the things FNA handles for us underneath the hood:
            base.Draw(gameTime);
        }

        //public static bool IsImageOutsideScreen(Texture2D imageRect)
        //{
        //    // Получаем размеры экрана
        //    int screenWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
        //    int screenHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

        //    // Проверяем, выходят ли координаты за пределы экрана
        //    if (imageRect.X < 0 || imageRect.Y < 0 ||
        //        imageRect.Width > gra.Viewport.Width ||
        //        imageRect.Height > GraphicsDevice.Viewport.Height)
        //    {
        //        return true; // Часть изображения выходит за экран
        //    }

        //    return false; // Изображение полностью внутри экрана
        //}
    }

    //public class Screen : Microsoft.Xna.Framework.Game
    //{
    //    GraphicsDeviceManager graphics;
    //    SpriteBatch spriteBatch;

    //    Texture2D backgroundTexture;
    //    Texture2D snowTexture;
    //    Vector2 position;
    //    private List<Snowflake> snowflakes;
    //    private Random random;

    //    public Screen()
    //    {
    //        graphics = new GraphicsDeviceManager(this);
    //        Content.RootDirectory = "Content";
    //        graphics.PreferredBackBufferWidth = 1280;
    //        graphics.PreferredBackBufferHeight = 720;
    //        graphics.IsFullScreen = false;
    //        graphics.ApplyChanges();
    //    }

    //    protected override void Initialize()
    //    {
    //        snowflakes = new List<Snowflake>();
    //        random = new Random();
    //        base.Initialize();
    //    }

    //    protected override void LoadContent()
    //    {
    //        spriteBatch = new SpriteBatch(GraphicsDevice);
    //        snowTexture = TextureLoader.Load("snowflake", Content);
    //        backgroundTexture = TextureLoader.Load("forest", Content);

    //        // Создаем несколько снежинок разного размера и скорости
    //        for (int i = 0; i < 50; i++)
    //        {
    //            float scale = (float)random.NextDouble() * 0.5f + 0.1f;
    //            float speed = (float)random.NextDouble() * 2f + 0.5f;
    //            Vector2 position = new Vector2(random.Next(1280), -random.Next(720));
    //            snowflakes.Add(new Snowflake(snowTexture, position, speed, 0f, scale));
    //        }
    //    }

    //    protected override void Update(GameTime gameTime)
    //    {
    //        base.Update(gameTime);

    //        foreach (var snowflake in snowflakes.ToList())
    //        {
    //            position.X += snowflake.Speed;

    //            if (position.Y > GraphicsDevice.Viewport.Height)
    //            {
    //                position = new Vector2(random.Next(1280), -random.Next(720));
    //            }
    //        }

    //        // Добавляем новые снежинки каждые 60 кадров (~1 секунда)
    //        if (gameTime.ElapsedGameTime.TotalSeconds >= 1)
    //        {
    //            snowflakes.Add(new Snowflake(TextureLoader.Load("snowflake", Content),
    //                new Vector2(random.Next(1280), -random.Next(720)),
    //                (float)random.NextDouble() * 2f + 0.5f,
    //                0f, (float)random.NextDouble() * 0.5f + 0.1f));
    //            //gameTime.ElapsedGameTime = TimeSpan.Zero;
    //        }
    //    }

    //    protected override void Draw(GameTime gameTime)
    //    {
    //        GraphicsDevice.Clear(Color.Transparent);

    //        spriteBatch.Begin();
    //        spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);

    //        foreach (var snowflake in snowflakes)
    //        {
    //            spriteBatch.Draw(snowflake.Texture, position, Color.White);
    //        }

    //        spriteBatch.End();

    //        base.Draw(gameTime);
    //    }
    //}

}
