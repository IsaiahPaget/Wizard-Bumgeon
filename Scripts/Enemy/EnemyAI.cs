using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    Enemy enemy;
    Rigidbody2D PlayerRb;
    Rigidbody2D EnemyRb;
    float followDistance;
    float movementSpeed;
    void Start() {
        PlayerRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        EnemyRb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        followDistance = enemy.getFollowDistance();
        movementSpeed = enemy.getMovementSpeed();
    }
    void FixedUpdate()
    {
        if (Vector2.Distance(PlayerRb.position, EnemyRb.position) < followDistance) {
        Vector2 lookDir = PlayerRb.position - EnemyRb.position;
        EnemyRb.MovePosition(EnemyRb.position + lookDir * (movementSpeed/100));
        }
    }
}
