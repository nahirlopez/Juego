using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador1 : MonoBehaviour
    
{
    // Start is called before the first frame update
    void Start()
    {
       
    }
 float movementSpeed = 0.1F;
    float rotar = 4F;

    // Update is called once per frame
    void Update()
    {
        
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate (0, rotar, 0);
            }
        
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate (0, -rotar, 0);
            }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate( movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-movementSpeed, 0,0 );
        }
        

    }
}
