using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Vector2 movement;
    bool spellCasted;
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
    }
    public Vector2 getMovement() {
        return movement;
    }
    public bool isSpellCasted() {
        return spellCasted;
    }
}
