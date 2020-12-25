using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlEnemy : MonoBehaviour
{

    public GameObject end;
    public float velocidad;

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        gameObject.transform.position = 
        Vector3.MoveTowards( 
            
            gameObject.transform.position,
            end.transform.position,
            velocidad * Time.deltaTime
        );
    }

    private void OnTriggerEnter2D( Collider2D other ) 
    {
        Debug.Log( "other.transform.name" );
        if( other.transform.name == "end1" )
        {
            Destroy( gameObject );
        }
    }
}
