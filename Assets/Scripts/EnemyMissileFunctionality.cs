using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissileFunctionality : MonoBehaviour
{
    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public float missileSpeed = 0.5f;

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
    //public GameObject enemyMissileExplosionReference;

    // Start is called before the first frame update
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
        float gradual = missileSpeed * Time.deltaTime;

        missileTransform.position = Vector3.MoveTowards(missileTransform.position, missileDirection, gradual);
    }

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    void OnTriggerEnter2D(Collider2D detectCollision)
    {
        // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
        Debug.Log(detectCollision.name);

        if (detectCollision.gameObject.tag == "City")
        {
            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            //Instantiate(enemyMissileExplosionReference, missileTransform.position, Quaternion.identity);

            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Destroy(gameObject);
        }

        if (detectCollision.gameObject.tag == "Player Bullet Explosion")
        {
            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Destroy(gameObject);
        }
    }
}
