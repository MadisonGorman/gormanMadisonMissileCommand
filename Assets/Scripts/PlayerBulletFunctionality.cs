using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletFunctionality : MonoBehaviour
{
    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public float bulletSpeed;

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public Transform bulletTransform;

    // Referenced: "How to make Missile Command in Unity - 04 - Click to spawn missile", by MetalStorm Games
    private Vector2 bulletTargetPosition;

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public GameObject playerBulletExplosionReference;

    // Start is called before the first frame update
    void Start()
    {
        // Referenced: "How to make Missile Command in Unity - 04 - Click to spawn missile", by MetalStorm Games
        // Establishes the current position of the mouse as the intended target, terminating position of the shot bullet
        bulletTargetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        // Referenced: "How to make Missile Command in Unity - 04 - Click to spawn missile", by MetalStorm Games
        // Causes the bullet to move towards the current mouse position at the previously defined speed
        bulletTransform.position = Vector2.MoveTowards(bulletTransform.position, bulletTargetPosition, bulletSpeed * Time.deltaTime);

        // Referenced: "How to make Missile Command in Unity - 05 - Spawning Explosions" by MetalStorm Games
        // Upon the bullet reaching the position at which the mouse was clicked, an explosion appears and said bullet is destroyed
        if(bulletTransform.position == (Vector3)bulletTargetPosition)
        {
            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Instantiate(playerBulletExplosionReference, bulletTransform.position, Quaternion.identity);

            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Destroy(gameObject);
        }     
    }
}
