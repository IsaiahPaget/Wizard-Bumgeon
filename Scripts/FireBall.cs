using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed;
    public Animator animator;
    public Collider2D fireballCollider;
    float destroyDelay = 0.333f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Collider2D playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        Collider2D playerGhostCollider = GameObject.FindGameObjectWithTag("PlayerGhost").GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(fireballCollider, playerCollider);
        Physics2D.IgnoreCollision(fireballCollider, playerGhostCollider);
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo) {
        FindAnyObjectByType<AudioManager>().Play("fireball_explosion");
        animator.SetBool("fireballCollided", true);
        rb.velocity = transform.up * 0;
        Invoke("DestroyFireBallPrefab", destroyDelay);
    }

    void DestroyFireBallPrefab() {
        Destroy(gameObject);

    }
}
