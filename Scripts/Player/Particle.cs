using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour
{
    public void playParticle(Vector3 transform)
    {
        Instantiate(gameObject, transform, new Quaternion());
        Invoke("killParticle", 0.5f);
    }

    void killParticle() {
        Destroy(gameObject);
    }
}
