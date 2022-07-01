using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gol : MonoBehaviour
{
    public int golRojo;
    public GameObject player1;
    public GameObject player2;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(631.7f, 15.99f, -2491.7f);
        player1.transform.position = new Vector3(635.2f, 17.7f, -2538.5f);
        player1.transform.eulerAngles = new Vector3(-88.40401f, 0, 0);
        player2.transform.position = new Vector3(635.38f, 17.7f, -2442.99f);
        player2.transform.eulerAngles = new Vector3(-89.855f, 0, 184.868f);
        golRojo = 0;


    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Finish")
        {
            golRojo++;
        }
    }
}
