using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseCannonFunctionality : MonoBehaviour
{
    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    // Referenced: "How to modify the Game Object Transform Pivot (Unity Tutorial)" by Code Monkey
    public Rigidbody2D tankBarrelPivotRb2d;

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    public Camera mainCamera;

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    Vector2 mousePosition;

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public GameObject bulletReference;

    // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
    public Transform bulletSpawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Upon the left mouse button being pressed, a bullet is spawned, appearing from the end of the Tank Barrel
        if (Input.GetMouseButtonDown(0))
        {
            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
            GameObject bullet = Instantiate(bulletReference, bulletSpawnLocation.position, bulletSpawnLocation.rotation);
        }

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        // Defines the position of the mouse as a concrete point within the game
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    // Enables the Tank Barrel to rotate, following the position of the mouse
    void FixedUpdate()
    {
        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        // Referenced: "How to modify the Game Object Transform Pivot (Unity Tutorial)" by Code Monkey
        Vector2 aimDirection = mousePosition - tankBarrelPivotRb2d.position;

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        float rotationAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        // Referenced: "How to modify the Game Object Transform Pivot (Unity Tutorial)" by Code Monkey
        tankBarrelPivotRb2d.rotation = rotationAngle;
    }
}
