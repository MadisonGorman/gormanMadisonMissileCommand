using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissileFunctionality : MonoBehaviour
{
    // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
    int randomAvailableCity;

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public Transform missileTransform;

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    public Rigidbody2D missileRb2d;

    // Start is called before the first frame update
    void Start()
    {
        GameController gc = GameObject.FindObjectOfType<GameController>();

        // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
        randomAvailableCity = Random.Range(0, gc.availableCitiesList.Count);

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
        Vector2 missileDirection = gc.availableCitiesList [randomAvailableCity].transform.position - missileTransform.position;

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        float rotationAngle = Mathf.Atan2(missileDirection.y, missileDirection.x) * Mathf.Rad2Deg - 90f;

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        missileRb2d.rotation = rotationAngle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
