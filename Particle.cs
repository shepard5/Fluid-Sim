public class Particle
{
    public vector2 position {get; set;}
    public vector2 velocity {get; set;}
    public float size {get; set;} 

    public Particle(vector2 position, vector2 velocity, float size)
    {
        Position = position;
        Velocity = velocity;
        Size = size;
    }
    Public void Update(float deltaTime)
    {
        
    }
}