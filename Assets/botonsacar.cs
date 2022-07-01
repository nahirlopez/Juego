using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonsacar : MonoBehaviour
{
    public GameObject perdiste;
    public GameObject boton;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void sacarbtn()
    {
        perdiste.SetActive(false);
        boton.SetActive(false);
    }
}

