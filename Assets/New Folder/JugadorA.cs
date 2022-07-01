using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    float movementSpeed = 0.5F;
    float rotar = 2F;
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, rotar);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, -rotar);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, -movementSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, movementSpeed, 0);
        }


    }
}
