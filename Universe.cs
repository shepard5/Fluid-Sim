public class Universe
{
    public float GravitationalAcceleration {get; set;}
    public Universe(float gravitationalAcceleration)
    {
        GravitationalAcceleration = gravitationalAcceleration;
    }
    public void ApplyGravity(Paticle particle)
    {
        particle.Velocity += new Vector2(0,-GravitationalAcceleration)
    }
}