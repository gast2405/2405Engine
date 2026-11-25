using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace _2405EngineLibrary.Input;

public class InputManager 
{
    public KeyboardInfo Keyboard { get; private set; }
    public MouseInfo Mouse { get; private set; }
    public InputManager()
    {
        Keyboard = new KeyboardInfo();
        Mouse = new MouseInfo();
    }
    public void Update(GameTime gameTime)
    {
        Keyboard.Update();
        Mouse.Update();
    }
}