using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemyExplosionsFunctionality : MonoBehaviour
{
    // Upon the termination of the Enemy Missile or Player Bullet Explosion's animation, said explosion is destroyed
    public void DestroyExplosion()
    {
        // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
        Destroy(gameObject);
    }
}
