class PhysicsSim
{
    static void Main(string[] args)
    {
        Universe universe = new Universe(9.81f);
        
        containerPosition = new vector2(0,0);
        containerOrientation = new float 0;
        containerSize = new vector2 (20,20);
        Conatiner container = new Conatiner(containerPosition, containerSize, containerOrientation;);
        particlePosition = new vector2 (0,0);
        particleVelocity = new vector2 (0,0);
        particleSize = new float 1;
        Particle particle = new Particle(particlePosition,particleVelocity,particleSize);
    }
}