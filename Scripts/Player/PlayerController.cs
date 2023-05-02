using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Player player;
    // The rigid body component attached to this GameObject
    Rigidbody2D rb;
    // The direction of movement as a vector
    Vector2 movement;
    float movementSpeed;
    void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update() {
        movementSpeed = player.getMovementSpeed();
    }
    void FixedUpdate() {
        // Move the player's rigid body based on the input and the move speed
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
        // Move the player sprite towards the position of the player's ghost using Lerp.
        player.transform.position = Vector2.Lerp(player.transform.position , rb.position, (movementSpeed* 0.9f ) * Time.deltaTime);
    }

    public void Move(Vector2 movementInput) {
        movement = movementInput;
    }
}
