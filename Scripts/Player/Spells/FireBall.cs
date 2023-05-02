using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    AnimationManager animationManager;

    [SerializeField]
    float damage;

    [SerializeField]
    Rigidbody2D rb;
    float destroyDelay = 1f;
    float lifeSpan = 5f;
    void Awake() {
        FindAnyObjectByType<AudioManager>().play("Spell_Cast_FireBall");
    }
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.up * speed;
        Invoke("DestroyFireBallPrefab", lifeSpan);
    }
    // Triggered when the fireball collides with another collider
    void OnTriggerEnter2D (Collider2D hitInfo) {
        // Play the explosion sound effect
        FindAnyObjectByType<AudioManager>().play("fireBallExplosion");
        // Trigger the fireball collision animation
        animationManager.PlayAnimation("fireballCollided");
        // Stop the fireball movement
        rb.velocity = transform.up * 0;
        // Delay before the fireball prefab is destroyed
        Invoke("DestroyFireBallPrefab", destroyDelay);
    }
    // Destroy the fireball prefab
    void DestroyFireBallPrefab() {
        Destroy(gameObject);
    }

    public float getSpeed() {
        return speed;
    }
    public float getDamage() {
        return damage;
    }
    public Rigidbody2D getFireballRigidBody2D() {
        return rb;
    }
    public void shoot(Vector3 FirePoint, Quaternion spellrotation) {
        Instantiate(gameObject, FirePoint, spellrotation);
    }
}
