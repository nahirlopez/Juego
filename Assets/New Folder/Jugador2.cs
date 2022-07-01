using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador2 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotar, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -rotar, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
    }
}
