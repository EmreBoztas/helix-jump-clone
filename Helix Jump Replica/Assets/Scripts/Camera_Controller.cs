    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public Transform main;
    public Vector3 offset;
    public float cameraSpeed;
    void Start()
    {
        offset = transform.position - main.position;
    }

    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, offset + main.position, cameraSpeed);
        transform.position = newPos;
    }
}
