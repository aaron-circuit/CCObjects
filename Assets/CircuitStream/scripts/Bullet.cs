using UnityEngine;

// Unit 2, Lecture 1. Plain class.
public class Bullet
{
    public float speed;
    public int damage;

    public Bullet(float speed, int damage)
    {
        this.speed = speed;
        this.damage = damage;
    }

    public void Move()
    {
        Debug.Log("Bullet travelling at " + speed);
    }

    // Takes a Health to damage. One object acting on another is the whole
    // point of OOP, and this is the first time we do it.
    public void OccurDamage(Health target)
    {
        target.DeductHealth(damage);
        Debug.Log("Hit for " + damage + ", target now on " + target.currentHealth);
    }
}
