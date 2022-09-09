using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissileFunctionality : MonoBehaviour
{
    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public float missileSpeed = 7;

    //private Transform cityOneTransform;
    //private Transform cityTwoTransform;
    //private Transform cityThreeTransform;
    //private Transform cityFourTransform;
    //private Transform cityFiveTransform;
    //private Transform citySixTransform;

    // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
    //List<Transform> availableCityPositionsList;

    // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
    //Transform randomAvailableCityPositions;

    //public Transform missileTransform;

    // Start is called before the first frame update
    void Start()
    {
        //cityOneTransform = GameObject.Find("City (1)").transform.GetComponent<Transform>();
        //cityTwoTransform = GameObject.Find("City (2)").transform.GetComponent<Transform>();
        //cityThreeTransform = GameObject.Find("City (3)").transform.GetComponent<Transform>();
        //cityFourTransform = GameObject.Find("City (4)").transform.GetComponent<Transform>();
        //cityFiveTransform = GameObject.Find("City (5)").transform.GetComponent<Transform>();
        //citySixTransform = GameObject.Find("City (6)").transform.GetComponent<Transform>();

        //availableCityPositionsList = new List<Transform>();

        //availableCityPositionsList.Add(cityOneTransform);
        //availableCityPositionsList.Add(cityTwoTransform);
        //availableCityPositionsList.Add(cityThreeTransform);
        //availableCityPositionsList.Add(cityFourTransform);
        //availableCityPositionsList.Add(cityFiveTransform);
        //availableCityPositionsList.Add(citySixTransform);
    }

    // Update is called once per frame
    void Update()
    {
        // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
        //randomAvailableCityPositions = Random.Range(availableCityPositionsList[0], availableCityPositionsList[5]);

        //float gradual = missileSpeed * Time.deltaTime;

        // Referenced: "How to Spawn Monsters Randomly from different Spawn Points and Make them Follow the Player in Unity." by Alexander Zotov
        //missileTransform.position = Vector3.MoveTowards(missileTransform.position, availableCityPositionsList [randomAvailableCityPositions], gradual);
    }
}
