using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Layer : MonoBehaviour
{
    [SerializeField] private Transform ball; 
    [SerializeField] private GameManager gm;
    void Start()
    {
    }

    void Update()
    {
        if(transform.position.y - 1f > ball.position.y)
        {
            gm.GameScore(25);
        }
    }
}
