using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarlicBehavior : MeleWeaponBehavior
{
    List<GameObject> markedEnemies;

    protected override void Start()
    {
        base.Start();
        markedEnemies = new List<GameObject>();
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy") && !markedEnemies.Contains(collision.gameObject))
        {
            EnemyStat enemy = collision.GetComponent<EnemyStat>();
            enemy.TakeDamage(currentDamage);

            markedEnemies.Add(collision.gameObject);  //Mark the enemy
        }
        else if (collision.CompareTag("Prop"))
        {
            if (collision.gameObject.TryGetComponent(out BreakableProps breakable))
            {
                breakable.TakeDamage(currentDamage);
                markedEnemies.Add(collision.gameObject);
            }
        }
    }
}