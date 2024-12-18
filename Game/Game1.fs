module Game

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input

type Game1() as this =
    inherit Game()

    let mutable graphics = new GraphicsDeviceManager(this)
    let mutable spriteBatch = Unchecked.defaultof<SpriteBatch>

    do base.Content.RootDirectory <- "Content"
    do base.IsMouseVisible <- true

    override this.Initialize() =
        // TODO: Add your initialization logic here

        base.Initialize()

    override this.LoadContent() =
        do spriteBatch <- new SpriteBatch(graphics.GraphicsDevice)

    // TODO: use this.Content to load your game content here

    override this.Update(gameTime) =
        if
            GamePad.GetState(PlayerIndex.One).Buttons.Back = ButtonState.Pressed
            || Keyboard.GetState().IsKeyDown(Keys.Escape)
        then
            base.Exit()

        // TODO: Add your update logic here

        base.Update(gameTime)

    override this.Draw(gameTime) =
        base.GraphicsDevice.Clear(Color.CornflowerBlue)

        // TODO: Add your drawing code here

        base.Draw(gameTime)
