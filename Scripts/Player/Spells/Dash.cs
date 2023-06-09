using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    [SerializeField]
    Particle particle;

    [SerializeField]
    float dashSpeed;

    [SerializeField]
    float dashLength;
    Player player;
    float initialMoveSpeed;
    void Awake() {
        player = GetComponent<Player>();
    }
    void resetMovementSpeed() {
        player.movementSpeed = initialMoveSpeed;
    }
    public void dash() {
        FindAnyObjectByType<AudioManager>().play("dash_sound");
        initialMoveSpeed = player.movementSpeed;
        player.movementSpeed *= dashSpeed;
        // particle.playParticle(player.transform.position);
        Invoke("resetMovementSpeed", dashLength);
    }
}
