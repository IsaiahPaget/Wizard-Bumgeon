using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Rigidbody2D PlayerGhost;
    public float movementSpeed;
    public HealthBar healthBar;
    void Start() {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position , PlayerGhost.position, movementSpeed * Time.deltaTime);
    }
}
