using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public Enemy stats;

    private void Start()
    {
        gameObject.tag = "Enemy";
        gameObject.layer = 11;
    }
}
