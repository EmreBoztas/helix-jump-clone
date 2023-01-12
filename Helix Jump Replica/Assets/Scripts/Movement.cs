using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float left;
    [SerializeField] private float right;
    private Vector3 currentAngle;

    void Start()
    {
         currentAngle = transform.eulerAngles;
    }

    void Update()
    {
        if(Input.GetButtonDown("Left"))
        {
            rotate(-1);
        }
        if(Input.GetButtonDown("Right"))
        {
            rotate(1);
        }
    }
    private void rotate(int move)
    {
        currentAngle = new Vector3(0, currentAngle.y + (45 * move), 0);
        transform.eulerAngles = currentAngle;
    }
}
