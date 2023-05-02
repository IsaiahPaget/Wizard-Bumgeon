using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    Enemy enemy;
    Rigidbody2D PlayerRb;
    Rigidbody2D EnemyRb;
    float followDistance;
    float movementSpeed;
    Vector2 lookDir;
    float moveAngle;
    void Awake() {
        enemy = GetComponent<Enemy>();
    }
    void Start() {
        PlayerRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        EnemyRb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        followDistance = enemy.getFollowDistance();
        movementSpeed = enemy.getMovementSpeed();
        lookDir = (PlayerRb.position - EnemyRb.position).normalized;
    }
    void FixedUpdate()
    {
        if (Vector2.Distance(PlayerRb.position, EnemyRb.position) < followDistance) {
            EnemyRb.MovePosition(EnemyRb.position + lookDir * movementSpeed * Time.deltaTime);
        }
    }
}
