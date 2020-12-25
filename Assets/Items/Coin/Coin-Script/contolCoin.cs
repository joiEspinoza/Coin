using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contolCoin : MonoBehaviour
{
    void Start()
    {

        
    }

    
    void Update()
    {
        Destroy( gameObject, 6f );
    }

    private void OnTriggerEnter2D( Collider2D other ) 
    {
        if( other.transform.name == "PJ" )
        {
            Destroy( gameObject );
        }; 
    }
}
