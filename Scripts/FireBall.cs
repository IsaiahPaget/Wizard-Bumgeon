using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed;                      // Speed at which the fireball moves
    public Animator animator;                // Animator component used to control the fireball animation
    public Collider2D fireballCollider;      // Collider component for the fireball object
    float destroyDelay = 0.333f;             // Delay before the fireball is destroyed after colliding with another object
    public Rigidbody2D rb;                  // Rigidbody2D component used to control the physics of the fireball

    // Start is called before the first frame update
    void Start()
    {
        // Ignore collision between the fireball and the player objects
        Collider2D playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        Collider2D playerGhostCollider = GameObject.FindGameObjectWithTag("PlayerGhost").GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(fireballCollider, playerCollider);
        Physics2D.IgnoreCollision(fireballCollider, playerGhostCollider);

        // Move the fireball in a straight line upwards which is arbitrary because of the rotation of the sprite, based on the given speed
        rb.velocity = transform.up * speed;
    }

    // Triggered when the fireball collides with another collider
    void OnTriggerEnter2D (Collider2D hitInfo) {
        // Play the explosion sound effect
        FindAnyObjectByType<AudioManager>().Play("fireball_explosion");

        // Trigger the fireball collision animation
        animator.SetBool("fireballCollided", true);

        // Stop the fireball movement
        rb.velocity = transform.up * 0;

        // Delay before the fireball prefab is destroyed
        Invoke("DestroyFireBallPrefab", destroyDelay);
    }

    // Destroy the fireball prefab
    void DestroyFireBallPrefab() {
        Destroy(gameObject);
    }
}
