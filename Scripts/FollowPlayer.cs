using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   public Rigidbody2D PlayerRb;
   public BoxCollider2D collider;
   public float movementSpeed;
   public Rigidbody2D rb;

   void start() {
    print("hello world!");
   }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 lookDir = PlayerRb.position - rb.position;
        rb.MovePosition(rb.position + lookDir * movementSpeed);
    }
}
