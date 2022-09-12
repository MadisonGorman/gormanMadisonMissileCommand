using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public GameObject missileReference;

    public float missileMinimumXPosition = -8.15f;
    public float missileMaximumXPosition = 8.15f;

    // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
    public List<GameObject> availableCitiesList;

    // Start is called before the first frame update
    // Enables an enemy missile to be created with a delay between the creation of each
    void Start()
    {
        InvokeRepeating("SpawnMissile", 1.0f, 2.0f);
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

    // Creates a missile at a defined y position and random x position
    public void SpawnMissile()
    {
        Vector3 missilePosition = new Vector3();

        missilePosition.x = Random.Range(missileMinimumXPosition, missileMaximumXPosition);
        
        missilePosition.y = 5.5f;

        // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        GameObject missile = Instantiate(missileReference, missilePosition, Quaternion.identity);
    }

    public void GameRestarts()
    {
        SceneManager.LoadScene(0); 
    }
}
