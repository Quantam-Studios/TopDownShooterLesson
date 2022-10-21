using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject[] Enemies;
    public Transform[] spawnPositions;
    public float setTimeBtwSpawns;
    private float timeBtwSpawns;

    private void Update()
    {
        timeBtwSpawns -= Time.deltaTime;

        if (timeBtwSpawns <= 0)
        {
            int randEnemy = Random.Range(0, Enemies.Length);
            int randPos = Random.Range(0, spawnPositions.Length);
            Instantiate(Enemies[randEnemy], spawnPositions[randPos].position, Quaternion.identity);
            timeBtwSpawns = setTimeBtwSpawns;
        }
    }
}
