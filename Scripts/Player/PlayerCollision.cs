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
        healthBar = player.getHealthBar();
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if (player.getInvincibility() == false) {
            enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                healthBar.SetHealth(player.getCurrentHealth() - 1f);
                player.setInvincibility(true);
                Invoke("setIsInvincible", player.getInvincibilityFrames());
            }
        }
    }
    void setIsInvincible() {
        player.setInvincibility(false);
    }
}
