using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ScreenSaver_Snowfall_Shamilova
{
    /// <summary>
    /// Основной класс программы.
    /// </summary>
    public class Screen : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Texture2D backgroundTexture;
        private SnowflakeHelper snowflakeHelper;
        private MouseState previousMouseState;

        /// <summary>
        /// Конструктор класса Screen.
        /// </summary>
        public Screen()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            previousMouseState = Mouse.GetState();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            var image = Content.Load<Texture2D>("snowflake");
            snowflakeHelper = new SnowflakeHelper(image, graphics);
            snowflakeHelper.CreateSnowflakes(50);
            backgroundTexture = Content.Load<Texture2D>("forest");
        }


        protected override void Update(GameTime gameTime)
        {
            Input.Update();
            var currentMouseState = Mouse.GetState();

            if (previousMouseState != currentMouseState ||
                Keyboard.GetState().GetPressedKeys().Length > 0)
            {
                Exit();
            }

            snowflakeHelper.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Transparent);
            spriteBatch.Begin();
            spriteBatch.Draw(backgroundTexture, new Rectangle(0, 0, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height), Color.White);
            snowflakeHelper.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}