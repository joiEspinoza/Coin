using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpawn : MonoBehaviour
{
    public GameObject Coin;

    private float time = 0;

    private float x;

    private float y;

    private Quaternion rotacionInicial;

    void Start()
    {
        
    }

    void Update()
    {

        time += Time.deltaTime;

        if( time > 3 )
        {

            x = Random.Range( -8.04f, 8.04f ); 

            y = Random.Range( -0.62f, -2.61f ); 

            Instantiate( Coin, new Vector3(x,y,0), rotacionInicial );

            time = 0;

        };
    }
}
