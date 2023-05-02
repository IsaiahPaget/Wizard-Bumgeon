using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellCast : MonoBehaviour
{
    // A reference to the camera used to get the mouse position
    Camera cam;
    // The point on the player where the fireball will spawn
    Transform FirePoint;
    // The position of the mouse in the world
    InputManager inputManager;

    [SerializeField]
    FireBall fireBallSpell;

    [SerializeField]
    Dash dashSpell;
    Vector3 mousePosition;
    // The direction in which the fireball will be shot
    Vector2 shootDirection;
    // The angle at which the fireball will be shot
    float shootAngle;
    // The rotation of the fireball
    Quaternion SpellRotation;
    void Awake() {
        cam = FindAnyObjectByType<Camera>();
        FirePoint = GameObject.Find("FirePoint").transform;
        inputManager = FindAnyObjectByType<InputManager>();
    }
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
        SpellRotation = Quaternion.Euler(0, 0, shootAngle);
    }

    public void fireBall()
    {   
        fireBallSpell.shoot(FirePoint.position, SpellRotation);
    }
    public void onDash() {
        dashSpell.dash();
    }
}
