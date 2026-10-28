using UnityEngine;

// Unit 2, Lecture 1.
//
// Still a plain class. Note the `using UnityEngine` at the top: a normal
// class is allowed to use Unity's API. That is NOT what makes something a
// component — inheriting from MonoBehaviour is.
public class Weapon
{
    public string weaponName;
    public int damage;
    public float bulletSpeed;

    // Two constructors. C# picks whichever matches how you call it.
    // This is "overloading", and it comes back properly in Lecture 4.
    public Weapon(string name, int damage)
    {
        weaponName = name;
        this.damage = damage;   // `this.` because the parameter has the
        bulletSpeed = 10f;      // same name as the field
    }

    public Weapon(string name, int damage, float bulletSpeed)
    {
        weaponName = name;
        this.damage = damage;
        this.bulletSpeed = bulletSpeed;
    }

    public void Shoot()
    {
        Debug.Log(weaponName + " fires for " + damage + " damage");
    }
}
