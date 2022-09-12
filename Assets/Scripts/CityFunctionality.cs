using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityFunctionality : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    void OnTriggerEnter2D(Collider2D detectCollision)
    {
        // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
        Debug.Log(detectCollision.name);

        GameController gc = GameObject.FindObjectOfType<GameController>();

        // Upon a city being hit by a missile, said city is removed from the list of available cities and destroyed
        if (detectCollision.gameObject.tag == "Missile")
        {
            // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
            // Referenced: stackoverflow.com/questions/24975441/how-to-have-a-game-object-remove-itself-from-a-list-unity3d, "How to have a Game Object remove itself from a list? (Unity3d)", Answer Provided by: Vengarioth, July 26, 2014 at 8:55PM
            gc.availableCitiesList.Remove(gameObject);

            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            Destroy(gameObject);
        }

        // Referenced: www.tutorialspoint.com/chash-program-to-check-whether-a-list-is-empty-or-not, "C# program to check whether a list is empty or not"
        // Upon the list of available cities containing 0 elements, the game restarts
        if (gc.availableCitiesList.Count == 0)
        {
            gc.GameRestarts();
        }
    }
}
