using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    private void Update()
    {
        if (health <= 0)
        {
            OnDeath();
        }
    }

    void OnDeath()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            BaseEnemy enemyStats = col.gameObject.GetComponent<BaseEnemy>();
            health -= Random.Range(enemyStats.stats.damageMin, enemyStats.stats.damageMax);
            Destroy(col.gameObject);
        }
    }
}
