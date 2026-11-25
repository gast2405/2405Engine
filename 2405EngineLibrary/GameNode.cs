using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _2405EngineLibrary;
public class GameNode
{
    public string Name { get; set; }
    public GameNode Parent { get; private set; }
    public List<GameNode> Children { get; } = new();

    public GameNode(String name = "GameNode")
    {
        Name = name;
    }

    public void AddChild(GameNode child)
    {
        child.Parent = this;
        Children.Add(child);
    }

    public virtual void Ready()
    {
        foreach (var child in Children)
        {
            child.Ready();
        }
    }

    public virtual void Update(GameTime gameTime)
    {
        foreach (var child in Children)
        {
            child.Update(gameTime);
        }
    }

    public virtual void Draw(SpriteBatch spriteBatch, GameTime gameTime)
    {
        foreach (var child in Children)
        {
            child.Draw(spriteBatch, gameTime);
        }
    }

}
