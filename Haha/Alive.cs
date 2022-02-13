namespace Haha;

public abstract class Alive : Entity
{

    public Alive()
    {
        x = 0;
        y = 0;
        move(1,2);
    }

    public bool isBlocked;

    public float attackStrength;

    public int velocity;
    
    public void move(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    
    public void attack(Alive target)
    {
        if (!target.isBlocked)
        {
            target.hp -= attackStrength;
        }
    }
    
    public void block()
    {
        isBlocked = true;
    }

}