public class Container
{ 
    public vector2 position {get; set;}
    public vector2 size {get; set;}
    public float orientation {get; set;}
    
    public Container(vector2 position, vector2 size, float orientation) 
    {
        Position = position
        Orientation = orientation
        Size = size
    }

//IsInside needs to be updated to allow for changes in orientation of the container 

//    public bool IsInside(Vector2 point)
//    {
        // Check if a given point is inside the container's boundaries.
//        float minX = Position.X - Width / 2;
//        float maxX = Position.X + Width / 2;
//        float minY = Position.Y - Height / 2;
//        float maxY = Position.Y + Height / 2;
//        return (point.X >= minX && point.X <= maxX && point.Y >= minY && point.Y <= maxY);
//    }
//}