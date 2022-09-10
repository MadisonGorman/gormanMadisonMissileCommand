using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// NOTE: Need to Alter the Missile's direction such that it is facing the correct way when moving towards the cities
public class GameController : MonoBehaviour
{
    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public GameObject missileReference;

    public float missileMinimumXPosition = -8.15f;
    public float missileMaximumXPosition = 8.15f;

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    public float missileForce = 15f;

    // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
    public List<GameObject> availableCitiesList;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMissile", 1.0f, 3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // Upon the player pressing the R key, the game restarts
        if(Input.GetKey(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }

    public void SpawnMissile()
    {
        Vector3 missilePosition = new Vector3();

        missilePosition.x = Random.Range(missileMinimumXPosition, missileMaximumXPosition);
        
        missilePosition.y = 5.5f;

        // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        GameObject missile = Instantiate(missileReference, missilePosition, Quaternion.identity);

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        Rigidbody2D missileRb2d = missile.GetComponent<Rigidbody2D>();

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        missileRb2d.AddForce(missilePosition * missileForce, ForceMode2D.Impulse);
    }
}
