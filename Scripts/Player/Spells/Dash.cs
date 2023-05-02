using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
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
        player.setMovementSpeed(initialMoveSpeed);
    }
    public void dash() {
        initialMoveSpeed = player.getMovementSpeed();
        player.setMovementSpeed(initialMoveSpeed * dashSpeed);
        Invoke("resetMovementSpeed", dashLength);
    }
}
