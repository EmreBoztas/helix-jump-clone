using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float left;
    [SerializeField] private float right;
    private bool rotating ;

    void Start()
    {
    }

    void Update()
    {
        if(Input.GetButtonDown("Left"))
        {
            StartRotation(-1);
        }
        if(Input.GetButtonDown("Right"))
        {
            StartRotation(1);
        }
    }
    
     public void StartRotation(int z)
    {
        if( !rotating )
            StartCoroutine( Rotate( new Vector3(0, 45 * z, 0), 1 ) ) ;
    }
 
    private IEnumerator Rotate( Vector3 angles, float duration )
    {
        rotating = true ;
        Quaternion startRotation = transform.rotation ;
        Quaternion endRotation = Quaternion.Euler( angles ) * startRotation ;
        for( float t = 0 ; t < duration ; t+= Time.deltaTime * 13 )
        {
            transform.rotation = Quaternion.Lerp( startRotation, endRotation, t / duration ) ;
            yield return null;
        }
        transform.rotation = endRotation  ;
        rotating = false;
    } 
}
