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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0)))
        // {

        //}

        // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
        mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
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
