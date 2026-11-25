using _2405EngineLibrary.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _2405EngineLibrary.GameNodes;

public class Sprite : GameNode2D
{
    public TextureRegion Region { get; set; }

    public SamplerState SamplerState { get; set; } = SamplerState.PointClamp;

    public Color Color { get; set; } = Color.White;

    public Vector2 Origin { get; set; } = Vector2.Zero;

    public SpriteEffects Effects { get; set; } = SpriteEffects.None;

    public float LayerDepth { get; set; } = 0.0f;

    public float Width => Region.Width * Transform.Scale.X;

    public float Height => Region.Height * Transform.Scale.Y;

    public Sprite() { }

    public Sprite(TextureRegion region) : base("SpriteGameNode")
    {
        Region = region;
    }

    public void CenterOrigin()
    {
        Origin = new Vector2(Region.Width, Region.Height) * 0.5f;
    }

    public override void Draw(SpriteBatch spriteBatch, GameTime gameTime)
    {
        spriteBatch.Begin(samplerState: SamplerState);
        Region.Draw(spriteBatch, Transform.GlobalPosition, Color, Transform.GlobalRotation, Origin, Transform.GlobalScale, Effects, LayerDepth);
        spriteBatch.End();
        base.Draw(spriteBatch, gameTime);
    }

}
