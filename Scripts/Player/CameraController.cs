using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform playerGhost;
    [SerializeField]
    Vector3 offSet;
    // Update is called once per frame
    void Update()
    {
        transform.position = playerGhost.position + offSet;
    }
}
