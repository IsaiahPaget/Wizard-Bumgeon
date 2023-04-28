using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    // Reference to the RigidBody2D component of the player ghost which the player sprite follows
    public Rigidbody2D PlayerGhost;
    public float movementSpeed;
    // reference to the HealthBar script
    public HealthBar healthBar;
    void Start() {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // Move the player sprite towards the position of the player's ghost using Lerp.
        transform.position = Vector2.Lerp(transform.position , PlayerGhost.position, movementSpeed * Time.deltaTime);
    }
}
