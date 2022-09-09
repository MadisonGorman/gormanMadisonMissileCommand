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
        Instantiate(missileReference, missilePosition, Quaternion.identity);
    }
}
