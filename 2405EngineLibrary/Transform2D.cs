using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace _2405EngineLibrary;
public class Transform2D : Transform
{
    public Vector2 Position { get; set; } = Vector2.Zero;
    public Vector2 Scale { get; set; } = Vector2.One;
    public float Rotation { get; set; } = 0f;
    public Vector2 GlobalPosition => Vector2.Transform(Vector2.Zero, GlobalMatrix);
    public Vector2 GlobalScale 
    {
        get
        {
            return new Vector2(
                new Vector2(GlobalMatrix.M11, GlobalMatrix.M12).Length(),
                new Vector2(GlobalMatrix.M21, GlobalMatrix.M22).Length()
                );
        }
    }
    public float GlobalRotation 
    {
        get
        {
            return MathF.Atan2(GlobalMatrix.M12, GlobalMatrix.M11); 
        }
    }
    public Transform2D Parent { get; set; }

    public Matrix LocalMatrix 
    { 
        get
        {
            return
                Matrix.CreateScale(Scale.X, Scale.Y, 1f) *
                Matrix.CreateRotationZ(Rotation) *
                Matrix.CreateTranslation(Position.X, Position.Y, 0f);
        }
    }

    public Matrix GlobalMatrix
    {
        get
        {
            if (Owner.Parent is GameNode2D parent) return LocalMatrix * parent.Transform.GlobalMatrix;
            return LocalMatrix;
        }
    }

    public Transform2D(GameNode owner) : base(owner)
    {

    }

}
