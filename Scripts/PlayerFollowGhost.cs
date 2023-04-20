using UnityEngine;

public class PlayerFollowGhost : MonoBehaviour
{
    public Rigidbody2D PlayerGhost;
    public Camera cam;
    public Rigidbody2D rb;
    public float movementSpeed;
    public Rigidbody2D swordRb;
    public CircleCollider2D circleCollider;
    Vector2 mousePosition;

    void Start() {
        Physics2D.IgnoreCollision(circleCollider, swordRb.GetComponent<Collider2D>());
    }
    // Update is called once per frame
    void Update() {
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position , PlayerGhost.position, movementSpeed * Time.deltaTime);
        Vector2 lookDir = mousePosition - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
