using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPj : MonoBehaviour
{

    #region Variables init

        public float velocidad = 0;
        public float empuje = 0;

        private Rigidbody2D RB2D; 

        private SpriteRenderer SR;

        private Animator Ani;

        private BoxCollider2D BC2D;

        private bool jump = true; 

        private int points = 0;

    #endregion
    
    void Start()
    {

        RB2D = gameObject.GetComponent<Rigidbody2D>();

        SR = gameObject.GetComponent<SpriteRenderer>();

        Ani = gameObject.GetComponent<Animator>();

        BC2D = gameObject.GetComponent<BoxCollider2D>();

    }

    void Update()
    {
     
    }

    private void FixedUpdate() 
    {

        #region Move

            if ( Input.GetKey( KeyCode.RightArrow ) )
            {

                RB2D.AddForce( new Vector2 ( velocidad * Time.deltaTime, 0 ) );
                
                SR.flipX = false;

                Ani.SetBool( "walkStart", true );

            }
            else
            {
                Ani.SetBool( "walkStart", false );

            };


            if ( Input.GetKey( KeyCode.LeftArrow ) )
            {
                RB2D.AddForce( new Vector2 ( -velocidad * Time.deltaTime, 0 ) );

                SR.flipX = true;

                Ani.SetBool( "walkStart", true );
            };


            if( Input.GetKey( KeyCode.Space ) && jump )
            {

                RB2D.AddForce( new Vector2 ( 0, empuje ) );

                jump = false;

                Ani.SetBool( "jumpStart", true );

            };

        #endregion

    }

    private void OnCollisionEnter2D( Collision2D other ) 
    {
        if( other.transform.tag == "floor" )
        {
            jump = true;

            Ani.SetBool( "jumpStart", false );
        }  
    }

    private void OnTriggerEnter2D( Collider2D other ) 
    {
        if( other.transform.tag == "Coin" )
        {
            points = points + 10;
            Debug.Log( points );
        };
    }

}

