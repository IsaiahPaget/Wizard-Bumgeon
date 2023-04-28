using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // The speed at which the player moves
    public float moveSpeed = 5f;

    // The circle collider used for collision detection
    public CircleCollider2D circleCollider;

    // The player's rigid body component
    public Rigidbody2D PlayerRb;

    // The rigid body component attached to this GameObject
    public Rigidbody2D rb;

    // The animator component attached to this GameObject
    public Animator animator;

    // The direction of movement as a vector
    Vector2 movement;
    void Start() {
        // Ignore collisions between the player and the circle collider
        Physics2D.IgnoreCollision(circleCollider, PlayerRb.GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        // Set the animator parameters based on the player's direction of movement where the string is the name of the animation
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
        // Move the player's rigid body based on the input and the move speed
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
