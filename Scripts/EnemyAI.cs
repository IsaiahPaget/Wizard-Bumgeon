using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    public Rigidbody2D PlayerRb;
    public float movementSpeed;
    public Rigidbody2D rb;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 lookDir = PlayerRb.position - rb.position;
        rb.MovePosition(rb.position + lookDir * movementSpeed);
    }
    void OnCollisionEnter2D (Collision2D hitInfo) {
        Debug.Log(hitInfo);
    }
}
