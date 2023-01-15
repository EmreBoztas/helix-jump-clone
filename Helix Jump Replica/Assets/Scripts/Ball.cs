using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce;
    [SerializeField] private GameObject splashPreFab;
    [SerializeField] private MeshRenderer meshRenderer;
    [SerializeField] private GameManager gm;

     float height;

    void Start()
    {
        height = (meshRenderer.bounds.size.y/2) - 0.02f;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.velocity = Vector3.up * jumpForce;
        GameObject newObject = Instantiate(splashPreFab, transform.position - new Vector3(0f, height,0f), transform.rotation);
        newObject.transform.SetParent(other.gameObject.transform);
        
        string metarialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        
        if (metarialName == "Safe (Instance)")
        {

        }
        else if (metarialName == "Killer (Instance)")
        {
            gm.RestartGame();
        }
        else if (metarialName == "Finish (Instance)")
        {
        }
    }    
    

}
