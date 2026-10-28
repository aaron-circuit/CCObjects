using UnityEngine;

// Unit 2, Lecture 1. Plain class.
//
// Notice what the Player HAS: a Health and a Weapon. Those are objects too.
// An object made of other objects is the normal shape of real code, and it
// is the first thing procedural code cannot do tidily.
public class Player
{
    public string playerName;
    public float speed;

    public Health health;    // a Player HAS a Health
    public Weapon weapon;    // and HAS a Weapon

    // private: nothing outside this class can read or write it.
    private int score;

    public Player(string name)
    {
        playerName = name;
        speed = 5f;

        // The Player builds its own Health and Weapon.
        health = new Health(100);
        weapon = new Weapon("Pistol", 10);

        score = 0;
    }

    public void Move(float x, float y)
    {
        Debug.Log(playerName + " moves to " + x + ", " + y);
    }

    public void Shoot()
    {
        weapon.Shoot();     // ask the weapon. The Player does not know how
    }

    public void Die()
    {
        Debug.Log(playerName + " died with " + score + " points");
    }

    // The only way in to a private field: a public method.
    // This is encapsulation, and Lecture 3 does it properly.
    public void AddScore(int amount)
    {
        score = score + amount;
    }

    public int GetScore()
    {
        return score;
    }
}
