using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public CircleCollider2D circleCollider;
    public Rigidbody2D PlayerRb;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    void Start() {
        Physics2D.IgnoreCollision(circleCollider, PlayerRb.GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        switch (movement.y)
        {
            case 1:
                animator.SetBool("movingDown", false);
                animator.SetBool("movingUp", true);
                animator.SetBool("movingLeft", false);
                animator.SetBool("movingRight", false);
                break;

            case -1:
                animator.SetBool("movingDown", true);
                animator.SetBool("movingUp", false);
                animator.SetBool("movingLeft", false);
                animator.SetBool("movingRight", false);
                break;

            default:
                switch (movement.x)
                {
                    case 1:
                        animator.SetBool("movingDown", false);
                        animator.SetBool("movingUp", false);
                        animator.SetBool("movingLeft", false);
                        animator.SetBool("movingRight", true);
                        break;

                    case -1:
                        animator.SetBool("movingDown", false);
                        animator.SetBool("movingUp", false);
                        animator.SetBool("movingLeft", true);
                        animator.SetBool("movingRight", false);
                        break;

                default:
                    animator.SetBool("movingDown", false);
                    animator.SetBool("movingUp", false);
                    animator.SetBool("movingLeft", false);
                    animator.SetBool("movingRight", false);
                    break;
                }
            break;
}
       
    }

    void FixedUpdate() {
        // physics
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
