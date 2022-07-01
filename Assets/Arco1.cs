using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arco1 : MonoBehaviour
{
    public GameObject Sphere;
    public GameObject CubePrefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)

    {
        if (col.gameObject.name == "Arco")
        {
            Debug.Log("ded");
            Destroy(Sphere);
        }
        if (col.gameObject.name == "Sphere")
        {
            GameObject cloncubo;
            for (int i = 0; i < 10; i++)
            {

                cloncubo = Instantiate(CubePrefab);
                Destroy(cloncubo, 5);

            }


        }

    }
}