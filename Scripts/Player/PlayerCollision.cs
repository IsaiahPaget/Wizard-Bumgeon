using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    Player player;
    HealthBar healthBar;
    Enemy enemy;
    void Start() {
        healthBar = GetComponent<HealthBar>();
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        // if (player.getInvincibility() == false) {
        //     enemy = collision.gameObject.GetComponent<Enemy>();
        //     if (enemy != null)
        //     {
        //         healthBar.SetHealth(player.getCurrentHealth() - 1);
        //         player.setInvincibility(true);
        //         Invoke("setIsInvincible", player.getInvincibilityFrames());
        //     }
        // }
        Debug.Log(collision);
    }
    void setIsInvincible() {
        player.setInvincibility(false);
    }
}
