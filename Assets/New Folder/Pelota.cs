using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pelota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        contequipoAzul = 0;
        gol.text = (contequipoAzul + " : " + contequipoRojo);
        contequipoRojo = 0;

        panel.SetActive(false);
    }
    float velocidad = 0.1F;
    public Text gol;
    int contequipoRojo;
    int contequipoAzul;
    public Text ganador;
    public GameObject panel;
    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "azul" && contequipoRojo < 5 && contequipoAzul < 5)
        {

            Debug.Log("Contacto");
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            contequipoRojo++;
            gol.text = "";
            gol.text = (contequipoAzul + " : " + contequipoRojo);
            Debug.Log(contequipoRojo + "   " + contequipoAzul);


        }
        else if (contequipoAzul == 5)
        {
            panel.SetActive(true);
            ganador.text = ("Ganador = EQUIPO AZUL!");

        }

        if (col.gameObject.tag == "rojo" && contequipoRojo < 5 && contequipoAzul < 5)
        {

            Debug.Log("Contacto");
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            contequipoAzul++;
            gol.text = "";
            gol.text = (contequipoAzul + " : " + contequipoRojo);

        }
        else if (contequipoRojo == 5)
        {
            panel.SetActive(true);
            ganador.text = ("Ganador = EQUIPO ROJO!");

        }

       
    }
}

