using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScatterBullet : MonoBehaviour
{
    private Bullet stats;

    private Vector2 target;

    public int maxShrapnel;
    public int minShrapnel;

    public float maxDeviation;
    public float minDeviation;

    public GameObject standardBullet;

    private void Awake()
    {
        stats = GetComponent<BaseBullet>().stats;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, stats.speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target) <= 0.1f)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        Scatter();
    }

    void Scatter()
    {
        int shrapnelCount = Random.Range(minShrapnel, maxShrapnel);

        for (int i = 0; i <= shrapnelCount; i++)
        {
            GameObject shrapnel = Instantiate(standardBullet, transform.position, Quaternion.identity);
            shrapnel.GetComponent<StandardPlayerBullet>().target = new Vector2(Random.Range(minDeviation * -1f, maxDeviation), Random.Range(minDeviation * -1f, maxDeviation));
        }
    }
}
