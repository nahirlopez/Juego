using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorB : MonoBehaviour
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, rotar);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -rotar);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, -movementSpeed, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, movementSpeed, 0);
        }
    }
}
