using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallShoot : MonoBehaviour
{
    // A reference to the camera used to get the mouse position
    public Camera cam;
    // The point on the player where the fireball will spawn
    public Transform FirePoint;
    // The prefab for the fireball
    public GameObject FireBallPrefab;
    // The position of the mouse in the world
    Vector3 mousePosition;
    // The direction in which the fireball will be shot
    Vector2 shootDirection;
    // The angle at which the fireball will be shot
    float shootAngle;
    // The rotation of the fireball
    Quaternion FireballRotation;

    // Update is called once per frame
    void Update()
    {
        // Get the position of the mouse in the world in Unity world units
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        // Calculate the direction in which the fireball should be shot
        shootDirection = mousePosition - FirePoint.position;
        // Calculate the angle at which the fireball should be shot
        shootAngle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg - 90f;
        // Create a rotation for the fireball based on the shoot angle
        FireballRotation = Quaternion.Euler(0, 0, shootAngle);

        // If the player clicks the left mouse button...
        if (Input.GetButtonDown("Fire1")) {
            // ...shoot a fireball from the FirePoint with the calculated rotation
            Shoot();
        }
    }

    // Instantiate a fireball at the FirePoint with the calculated rotation
    void Shoot() {
        Instantiate(FireBallPrefab, FirePoint.position, FireballRotation);
    }
}
