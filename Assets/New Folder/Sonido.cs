using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // Start is called before the first frame update
   // void start()
  //{ 
      // if(gol = GetComponent<AudioSource>())
    //{
       // AudioSource gol;
    //}
  //}
    
   
public class Sonido : MonoBehaviour
{
    private AudioSource gol;
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
       if ( col.gameObject.name == "Sphere")
        {
            gol.Play();
        }
    }
}
