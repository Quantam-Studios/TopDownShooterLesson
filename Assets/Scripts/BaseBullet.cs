using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBullet : MonoBehaviour
{
    public Bullet stats;

    private void Start()
    {
        if (stats.isPlayers == true) // player's bullet
            gameObject.layer = 9;
        else // enemy bullet
            gameObject.layer = 10;
    }
}
