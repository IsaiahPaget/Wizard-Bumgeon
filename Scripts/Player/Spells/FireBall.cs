using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    AnimationManager animationManager;
    float destroyDelay = 1f;
    float lifeSpan = 5f;

    [SerializeField]
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        FindAnyObjectByType<AudioManager>().Play("Spell_Cast_FireBall");
        rb.velocity = transform.up * speed;
        Invoke("DestroyFireBallPrefab", lifeSpan);
    }
    // Triggered when the fireball collides with another collider
    void OnTriggerEnter2D (Collider2D hitInfo) {
        // Play the explosion sound effect

        // Trigger the fireball collision animation
        animationManager.PlayAnimation("fireballCollided");

        // Stop the fireball movement
        rb.velocity = transform.up * 0;

        // Delay before the fireball prefab is destroyed
        Invoke("DestroyFireBallPrefab", destroyDelay);
    }

    // Destroy the fireball prefab
    void DestroyFireBallPrefab() {
        FindAnyObjectByType<AudioManager>().Play("Spell_Cast_FireBall");
        Destroy(gameObject);
    }
}
