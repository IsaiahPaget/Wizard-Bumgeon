using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField]
    InputManager inputManager;
    [SerializeField]
    PlayerController playerController;
    Vector2 movement;

    [SerializeField]
    float maxHealth;

    [HideInInspector]
    float currentHealth;
    bool isInvincible = false;

    [SerializeField]
    int invincibilityFrames;
    
    [SerializeField]
    Rigidbody2D rb;

    [SerializeField]
    float movementSpeed;

    [SerializeField]
    HealthBar healthBar;
    Slider healthBarSlider;
    void Start() {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    void Update() {
        healthBarSlider = healthBar.GetComponent<Slider>();
        currentHealth = healthBarSlider.value;
        movement = inputManager.getMovement();
        playerController.Move(movement);
    }
    public void setInvincibility(bool invincibility) {
        isInvincible = invincibility;
    }
    public float getCurrentHealth() {
        return currentHealth;
    }
    public float getMovementSpeed() {
        return movementSpeed;
    }
    public int getInvincibilityFrames() {
        return invincibilityFrames;
    }
    public Vector2 getMovement() {
        return movement;
    }
    public bool getInvincibility() {
        return isInvincible;
    }
}
