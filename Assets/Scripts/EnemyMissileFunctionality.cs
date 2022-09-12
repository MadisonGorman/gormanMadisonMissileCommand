using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissileFunctionality : MonoBehaviour
{
    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public float missileSpeed;

    // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
    int randomAvailableCity;

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public Transform missileTransform;

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    public Rigidbody2D missileRb2d;

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    Vector2 missileDirection;

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    float rotationAngle;

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public GameObject enemyMissileExplosionReference;

    // Start is called before the first frame update
    // Defines a random city for the missile to venture towards; determines the rotation of the missile
    void Start()
    {
        GameController gc = GameObject.FindObjectOfType<GameController>();

        // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
        randomAvailableCity = Random.Range(0, gc.availableCitiesList.Count);

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
        missileDirection = gc.availableCitiesList[randomAvailableCity].transform.position;

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        rotationAngle = Mathf.Atan2(missileDirection.y, missileDirection.x) * Mathf.Rad2Deg - 90f;

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        missileRb2d.rotation = rotationAngle;
    }

    // Update is called once per frame
    void Update()
    {
        // Results in the missile venturing towards a random city
        float gradual = missileSpeed * Time.deltaTime;

        missileTransform.position = Vector3.MoveTowards(missileTransform.position, missileDirection, gradual);

        // Referenced: "How to make Missile Command in Unity - 05 - Spawning Explosions" by MetalStorm Games
        // If there are multiple missiles venturing towards the same city, and said city is destroyed, the missiles which spawned prior are destroyed and an explosion appears where the city was prior to its destruction
        if (missileTransform.position == (Vector3)missileDirection)
        {
            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Instantiate(enemyMissileExplosionReference, missileTransform.position, Quaternion.identity);

            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Destroy(gameObject);
        }
    }

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    // Upon a missile hitting a city or a player's bullet explosion, the missile is destroyed and an explosion appears 
    void OnTriggerEnter2D(Collider2D detectCollision)
    {
        // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
        Debug.Log(detectCollision.name);

        if (detectCollision.gameObject.tag == "City")
        {
            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Instantiate(enemyMissileExplosionReference, missileTransform.position, Quaternion.identity);

            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Destroy(gameObject);
        }

        if (detectCollision.gameObject.tag == "Player Bullet Explosion")
        {
            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Instantiate(enemyMissileExplosionReference, missileTransform.position, Quaternion.identity);

            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Destroy(gameObject);
        }
    }
}
