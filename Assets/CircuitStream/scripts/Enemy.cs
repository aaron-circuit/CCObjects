using UnityEngine;

// Unit 2, Lecture 1. Plain class.
//
// Almost identical to Player, which should feel wrong. Two classes doing
// the same job with the same fields is exactly the duplication that
// INHERITANCE removes, and that is Lecture 2.
//
// Leave it duplicated tonight. Noticing the problem is the lesson.
public class Enemy
{
    public EnemyType type;     // the enum, used as a variable type
    public float speed;

    public Health health;
    public Weapon weapon;

    public Enemy(EnemyType type)
    {
        this.type = type;

        // Different enemies, different stats. A switch on the enum.
        switch (type)
        {
            case EnemyType.Melee:
                speed = 4f;
                health = new Health(60);
                weapon = new Weapon("Fists", 15);
                break;

            case EnemyType.Shooter:
                speed = 2f;
                health = new Health(40);
                weapon = new Weapon("Rifle", 12, 20f);
                break;

            case EnemyType.Exploder:
                speed = 6f;
                health = new Health(20);
                weapon = new Weapon("Self", 40);
                break;

            case EnemyType.MachineGun:
                speed = 1.5f;
                health = new Health(80);
                weapon = new Weapon("Machine Gun", 5, 30f);
                break;
        }
    }

    public void Move()
    {
        Debug.Log(type + " enemy moves at " + speed);
    }

    public void Shoot()
    {
        weapon.Shoot();
    }

    public void Die()
    {
        Debug.Log(type + " enemy died");
    }
}
