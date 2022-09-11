using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemyExplosionsFunctionality : MonoBehaviour
{
    public void DestroyExplosion()
    {
        // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
        Destroy(gameObject);
    }
}
