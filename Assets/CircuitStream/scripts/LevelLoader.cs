using UnityEngine;

// Unit 2, Lecture 1, Section 2.
//
// THE ONLY MonoBehaviour tonight. It inherits from MonoBehaviour, so it can
// go on a GameObject, and Unity will call Start() for it.
//
// Everything else tonight is a plain class that this one creates. Later in
// the unit this becomes a proper GameManager.
public class LevelLoader : MonoBehaviour
{
    private Player player;
    private Enemy enemy;

    void Start()
    {
        // `new` is how you make an object from a class.
        // Nothing in Unity does this for you — that is the difference.
        player = new Player("Aaron");
        enemy = new Enemy(EnemyType.Shooter);

        Debug.Log("--- Level loaded ---");

        player.Move(3f, 0f);
        player.Shoot();

        enemy.Move();
        enemy.Shoot();

        // One object acting on another.
        Bullet bullet = new Bullet(20f, 12);
        bullet.OccurDamage(player.health);

        if (player.health.IsDead())
        {
            player.Die();
        }
    }
}
