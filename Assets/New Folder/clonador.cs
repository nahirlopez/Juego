using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject cubitos;

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Sphere")
        {
            for (int i =0; i < 10; i++)
            {
                GameObject clon = Instantiate(cubitos);
                Destroy(clon, 2);
            }

        }
           

    }
}
