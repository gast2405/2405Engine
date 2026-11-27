using _2405EngineLibrary.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;


namespace _2405Engine;
public class Engine : Core
{
    public Engine() : base("_2405Engine", 1920, 1080, false)
    {
        
    }

    protected override void Initialize()
    {
        base.Initialize();
        VisiualizeEditorGUI(false); //disable the editor GUI
    }

    protected override void LoadContent()
    {
        base.LoadContent();

    }

    protected override void Update(GameTime gameTime)
    {
        base.Update(gameTime);

        if (Input.Keyboard.WasKeyJustPressed(Keys.OemTilde))
        {
            VisiualizeEditorGUI(!Core.EditorGui.IsVisible);
        }
    }

}
