using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Vector2 movement;
    public bool spellCasted;
    public bool dashing;
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
}




