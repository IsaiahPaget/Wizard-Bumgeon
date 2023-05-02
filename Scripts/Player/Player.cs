using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    InputManager inputManager;
    [SerializeField]
    PlayerController playerController;
    Vector2 movement;

    [SerializeField]
    float maxHealth;

    [HideInInspector]
    float currentHealth;

    [SerializeField]
    int invincibilityFrames;
    bool isInvincible = false;

    [SerializeField]
    int spellCoolDownFrames;
    bool isInSpellCoolDown = false;
    Rigidbody2D rb;

    [SerializeField]
    float movementSpeed;

    SpellCast spellCast;

    [SerializeField]
    HealthBar healthBar;
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
        movement = inputManager.getMovement();
        playerController.Move(movement);
        if (!isInSpellCoolDown){
            checkForSpellCasts();
        }
    }
    void checkForSpellCasts() {
        if(inputManager.isSpellCasted()) {
            spellCast.fireBall();
            spellCasted();
        }
        if (inputManager.isDashing()) {
            spellCast.onDash();
            spellCasted();
        }
    }
    void spellCasted() {
        setIsSpellCoolDown(true);
        Invoke("setSpellCoolDownFalse", spellCoolDownFrames);
    }
    void setSpellCoolDownFalse() {
        setIsSpellCoolDown(false);
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
    public HealthBar getHealthBar() {
        return healthBar;
    }
    public int getSpellCoolDownFrames() {
        return spellCoolDownFrames;
    }
    public bool getIsInSpellCoolDown() {
        return isInSpellCoolDown;
    }


    public void setInvincibility(bool invincibility) {
        isInvincible = invincibility;
    }
    public void setIsSpellCoolDown(bool isSpellCoolDown) {
        isInSpellCoolDown = isSpellCoolDown;
    }
    public void setMovementSpeed(float speed) {
        movementSpeed = speed;
    }
}
