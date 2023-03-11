using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardEnemy : MonoBehaviour
{
    private Enemy stats;

    [HideInInspector]
    public Transform player;

    private void Awake()
    {
        stats = GetComponent<BaseEnemy>().stats;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.Log($"{stats.health}");
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.position, stats.speed * Time.deltaTime);
        if (stats.health <= 0)
        {
            OnDeath();
        }
    }

    void OnDeath()
    {
        Destroy(gameObject);
        ScoreManager.AddScore(stats.points);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            stats.health -= col.gameObject.GetComponent<BaseBullet>().stats.damage;
            Destroy(col.gameObject);
        }
    }
}
