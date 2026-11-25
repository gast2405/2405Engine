
namespace _2405EngineLibrary.GameNodes;
public class CollisionShape : GameNode2D
{
    public Circle Shape { get; set; }
    public bool IsTrigger { get; set; } = false;
    public CollisionShape()
    {
        Shape = new Circle();
    }

    public CollisionShape(Circle shape)
    {
        Shape = shape;
    }
}

