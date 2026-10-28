// Unit 2, Lecture 1.
//
// A PLAIN C# CLASS. No "using UnityEngine", no MonoBehaviour, and it cannot
// be dragged onto a GameObject. It is a thing that exists in memory, made
// with `new`, owned by whoever made it.
//
// Put it in Assets/Scripts like any other script. Unity compiles it happily.
public class Health
{
    public int currentHealth;
    public int maxHealth;

    // A CONSTRUCTOR. Same name as the class, no return type.
    // It runs once, when someone writes `new Health(100)`.
    public Health(int max)
    {
        maxHealth = max;
        currentHealth = max;   // you start full
    }

    public void AddHealth(int amount)
    {
        currentHealth = currentHealth + amount;

        // Never go above the maximum.
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    public void DeductHealth(int amount)
    {
        currentHealth = currentHealth - amount;

        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public bool IsDead()
    {
        return currentHealth <= 0;
    }
}
