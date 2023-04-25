using UnityEngine;

public class PlayerFollowGhost : MonoBehaviour
{
    public Rigidbody2D PlayerGhost;
    public float movementSpeed;
    public Rigidbody2D swordRb;
    public CircleCollider2D circleCollider;

    void Start() {
        Physics2D.IgnoreCollision(circleCollider, swordRb.GetComponent<Collider2D>());
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position , PlayerGhost.position, movementSpeed * Time.deltaTime);
    }
}
