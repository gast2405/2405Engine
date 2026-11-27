using _2405EngineLibrary.Audio;
using _2405EngineLibrary.Input;
using _2405EngineLibrary;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Gum.Forms.Controls;
using Gum.GueDeriving;
using System;
using Gum.Forms;
//using Gum.Themes.Editor;
using _2405Engine.Editor.Layouts;


public class Core : Game
{
    internal static Core s_instance;

    public static Core Instance => s_instance;

    public static GraphicsDeviceManager Graphics { get; private set; }

    public static new GraphicsDevice GraphicsDevice { get; private set; }

    public static SpriteBatch SpriteBatch { get; private set; }

    public static new ContentManager Content { get; private set; }

    public static InputManager Input { get; private set; }

    public static AudioController Audio { get; private set; }

    public static SpriteFont DefaultFont { get; private set; }
    public static SpriteFont DefaultFont5X { get; private set; }

    public static GameNode RootGameNode { get; private set; }

    public static EditorLayout CurrentEditorLayout { get; private set; }

    public static Panel EditorGui { get; private set; }

    public Core(string title, int width, int height, bool fullScreen)
    {
        if (s_instance != null)
        {
            throw new InvalidOperationException($"Only a single Core instance can be created");
        }

        s_instance = this;

        Graphics = new GraphicsDeviceManager(this);
        Graphics.PreferredBackBufferWidth = width;
        Graphics.PreferredBackBufferHeight = height;
        Graphics.IsFullScreen = fullScreen;
        Graphics.ApplyChanges();
        Window.Title = title;
        Content = base.Content;
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        
        GraphicsDevice = base.GraphicsDevice;
        SpriteBatch = new SpriteBatch(GraphicsDevice);
        Input = new InputManager();
        Audio = new AudioController();
        RootGameNode = new GameNode("Root");
        InitializeGum();
        EditorGui = new Panel();
        EditorGui.Dock(Gum.Wireframe.Dock.Fill);
        EditorGui.AddToRoot();
        CurrentEditorLayout = new DefaultLayout();
        base.Initialize();
    }

    protected override void LoadContent()
    {
        DefaultFont = Content.Load<SpriteFont>("fonts/default");
        DefaultFont5X = Content.Load<SpriteFont>("fonts/default_5x");

        base.LoadContent();
    }

    protected override void UnloadContent()
    {
        Audio.Dispose();

        base.UnloadContent();
    }

    protected override void Update(GameTime gameTime)
    {
        Input.Update(gameTime);
        Audio.Update();
        RootGameNode.Update(gameTime);
        Gum.GumService.Default.Update(gameTime);
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.Black);
        RootGameNode.Draw(SpriteBatch, gameTime);
        Gum.GumService.Default.Draw();
        base.Draw(gameTime);
    }

    private void InitializeGum()
    {
        Gum.GumService.Default.Initialize(this, DefaultVisualsVersion.V3);

        //EditorTheme.Apply();

        Gum.GumService.Default.ContentLoader.XnaContentManager = Core.Content;

        FrameworkElement.KeyboardsForUiControl.Add(Gum.GumService.Default.Keyboard);
        FrameworkElement.GamePadsForUiControl.AddRange(Gum.GumService.Default.Gamepads);
        FrameworkElement.TabReverseKeyCombos.Add(
           new KeyCombo() { PushedKey = Gum.Forms.Input.Keys.Up });

        FrameworkElement.TabKeyCombos.Add(
           new KeyCombo() { PushedKey = Gum.Forms.Input.Keys.Down });

        Gum.GumService.Default.CanvasWidth = GraphicsDevice.PresentationParameters.BackBufferWidth;

        Gum.GumService.Default.CanvasHeight = GraphicsDevice.PresentationParameters.BackBufferHeight;

        Gum.GumService.Default.Renderer.Camera.Zoom = 1.0f;
    }

    public void VisiualizeEditorGUI(bool enable = true)
    {
        EditorGui.IsVisible = enable;
    }
}
