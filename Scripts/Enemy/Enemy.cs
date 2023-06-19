using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{   

    public HealthBar healthBar;

    [SerializeField]
    float maxHealth;

    public float currentHealth;
    
    [SerializeField]
    public float followDistance;

    [SerializeField]
    public float movementSpeed;

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
}
