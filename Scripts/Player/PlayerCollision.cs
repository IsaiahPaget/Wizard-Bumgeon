using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    Player player;
    HealthBar healthBar;
    Enemy enemy;

    void Awake() {
        player = GetComponent<Player>();
        healthBar = player.healthBar;
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (player.isInvincible == false) {
            enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                healthBar.SetHealth(player.currentHealth - 1f);
                player.isInvincible = true;
                Invoke("setIsInvincibleFalse", player.invincibilityFrames);
            }
        }
    }
    void setIsInvincibleFalse() {
        player.isInvincible = false; 
    }
}
