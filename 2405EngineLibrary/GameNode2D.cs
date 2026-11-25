using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _2405EngineLibrary;
public class GameNode2D: GameNode
{
    public Transform2D Transform { get; }


    public GameNode2D(string name = "GameNode2D") : base(name)
    {
        Transform = new Transform2D(this);
    }
}

