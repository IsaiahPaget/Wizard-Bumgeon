using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallShoot : MonoBehaviour
{
    public Camera cam;
    public Transform FirePoint;
    public GameObject FireBallPrefab;
    Vector3 mousePosition;
    Vector2 shootDirection;
    float shootAngle;
    Quaternion FireballRotation;
    // Update is called once per frame
    void Update()
    {
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        shootDirection = mousePosition - FirePoint.position;
        shootAngle = Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg - 90f;
        FireballRotation = Quaternion.Euler(0, 0, shootAngle);

        if (Input.GetButtonDown("Fire1")) {
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(FireBallPrefab, FirePoint.position, FireballRotation);
    }
}
