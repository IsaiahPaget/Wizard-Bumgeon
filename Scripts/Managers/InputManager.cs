using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Vector2 movement;
    bool spellCasted;
    bool dashing;
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Fire1")){
            spellCasted = true;
        } else {
            spellCasted = false;
        }

        if (Input.GetButtonDown("Jump")) {
            dashing = true;
        } else {
            dashing = false;
        }
    }
    public Vector2 getMovement() {
        return movement;
    }
    public bool isSpellCasted() {
        return spellCasted;
    }
    public bool isDashing() {
        return dashing;
    }
}
