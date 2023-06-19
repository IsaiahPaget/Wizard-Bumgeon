using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    InputManager inputManager;

    [SerializeField]
    PlayerController playerController;
    public Vector2 movement;

    [SerializeField]
    float maxHealth;

    [HideInInspector]
    public float currentHealth { get;  private set; }

    [SerializeField]
    public int invincibilityFrames { get; private set; }

    public bool isInvincible = false; 

    [SerializeField]
    int spellCoolDownFrames;
    bool isInSpellCoolDown = false;
    Rigidbody2D rb;

    [SerializeField]
    public float movementSpeed;

    SpellCast spellCast;
    public HealthBar healthBar;
    Slider healthBarSlider;
    void Awake() {
        inputManager = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody2D>();
        spellCast = GetComponent<SpellCast>();
        healthBarSlider = healthBar.GetComponent<Slider>();
    }
    void Start() {
        currentHealth = maxHealth;
        healthBar.setMaxHealth(maxHealth);
    }
    void Update() {
        currentHealth = healthBarSlider.value;
        movement = inputManager.movement;
        playerController.Move(movement);
        if (!isInSpellCoolDown){
            checkForSpellCasts();
        }
    }
    void checkForSpellCasts() {
        if(inputManager.spellCasted) {
            spellCast.fireBall();
            spellCasted();
        }
        if (inputManager.dashing) {
            spellCast.onDash();
            spellCasted();
        }
    }
    void spellCasted() {
        isInSpellCoolDown = true;
        Invoke("setSpellCoolDownFalse", spellCoolDownFrames);
    }
    void setSpellCoolDownFalse() {
        isInSpellCoolDown = false;
    }
}
