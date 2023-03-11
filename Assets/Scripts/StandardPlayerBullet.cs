using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardPlayerBullet : MonoBehaviour
{
    private Bullet stats;

    [HideInInspector]
    public Vector2 target;

    private void Awake()
    {
        stats = GetComponent<BaseBullet>().stats;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, stats.speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) <= 0.1f)
        {
            Destroy(gameObject);
        }
    }
}
