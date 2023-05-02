using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{   
    [SerializeField]
    HealthBar healthBar;

    [SerializeField]
    float maxHealth;

    float currentHealth;

    [SerializeField]
    float followDistance;

    [SerializeField]
    float movementSpeed;

    Rigidbody2D rb;
    Slider healthBarSlider;
    void Awake() {
        rb = GetComponent<Rigidbody2D>();
        healthBarSlider = healthBar.GetComponent<Slider>();
    }
    void Start () {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    // Update is called once per frame
    void Update () {
        currentHealth = healthBarSlider.value;
        if (currentHealth <= 0) {
            Destroy(gameObject);
        }
    }
    public float getFollowDistance() {
        return followDistance;
    }
    public float getCurrentHealth() {
        return currentHealth;
    }
    public float getMovementSpeed() {
        return movementSpeed;
    }
    public HealthBar getHealthBar() {
        return healthBar;
    }
}
