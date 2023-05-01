using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{   
    [SerializeField]
    HealthBar healthBar;

    [SerializeField]
    float maxHealth;

    [HideInInspector]
    float currentHealth;

    [SerializeField]
    float followDistance;

    [SerializeField]
    float movementSpeed;

    [SerializeField]
    Rigidbody2D rb;
    Slider healthBarSlider;
    void Start () {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    // Update is called once per frame
    void Update () {
        healthBarSlider = healthBar.GetComponent<Slider>();
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
}
