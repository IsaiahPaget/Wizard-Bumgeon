using UnityEngine;

public class PlayerFollowGhost : MonoBehaviour
{
    public Rigidbody2D PlayerGhost;
    public float movementSpeed;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position , PlayerGhost.position, movementSpeed * Time.deltaTime);
    }
}
