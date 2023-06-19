using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {
    HealthBar healthBar;
    Enemy enemy;
    FireBall fireBall;
    void Awake() {
        enemy = GetComponent<Enemy>();
        healthBar = enemy.healthBar;
    }
    void OnTriggerEnter2D(Collider2D collision) {
        fireBall = collision.gameObject.GetComponent<FireBall>();
        if (fireBall != null) {
            healthBar.SetHealth(enemy.currentHealth - fireBall.damage);
        }
    }
}
