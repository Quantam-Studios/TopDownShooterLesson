using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bullet;
    private Bullet stats;

    private float timeToShoot;

    private void Awake()
    {
        stats = bullet.GetComponent<BaseBullet>().stats;
    }

    void Update()
    {
        timeToShoot -= Time.deltaTime;

        if (Input.GetMouseButtonDown(0) && timeToShoot <= 0)
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
            timeToShoot = stats.coolDown;
        }
    }
}
