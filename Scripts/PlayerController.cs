using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public CircleCollider2D circleCollider;
    public Rigidbody2D PlayerRb;
    public Rigidbody2D swordRb;
    public Rigidbody2D rb;
    Vector2 movement;
    void Start() {
        Physics2D.IgnoreCollision(circleCollider, PlayerRb.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(circleCollider, swordRb.GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        //input
       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() {
        // physics
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
