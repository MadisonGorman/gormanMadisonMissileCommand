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

    // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
    public float bulletForce = 20f;

    public Transform bulletTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Referenced: "2D Shooting in Unity (Tutorial)" by Brackeys
            // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
            GameObject bullet = Instantiate(bulletReference, bulletSpawnLocation.position, bulletSpawnLocation.rotation);

            // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
            Rigidbody2D bulletRb2d = bullet.GetComponent<Rigidbody2D>();

            // Referenced: "TOP DOWN SHOOTING in Unity" by Brackeys
            bulletRb2d.AddForce(bulletSpawnLocation.up * bulletForce, ForceMode2D.Impulse);
        }

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
