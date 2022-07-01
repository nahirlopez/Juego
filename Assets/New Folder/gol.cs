using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gol : MonoBehaviour
{public int golRojo;
    public GameObject player1;
    public GameObject player2;
    public GameObject arcorojo;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        player1.transform.position = new Vector3(0.36f, 0, 0);
        player1.transform.eulerAngles = new Vector3(0, 0, 0);
        player2.transform.position = new Vector3(2.41f, 1.27f, -0.4771447f);
        player2.transform.eulerAngles = new Vector3(0, 0, 0);
        golRojo = 0;


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Finish")
        {
            golRojo++;
        }
    }
}
