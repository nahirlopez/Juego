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
        iscountign = true;

    }
    float velocidad = 0.1F;
    public Text gol;
    int contequipoRojo;
    int contequipoAzul;
    public Text ganador;
    public GameObject panel;
    public GameObject player1;
    public GameObject player2;

    float time = 0;
    public Text timer;
    public GameObject perdiste;
    bool iscountign;
    public Text perdio;
    // Update is called once per frame
    void Update()
    {
        if (iscountign)
        {
            time += Time.deltaTime;
        }

        timer.text = Mathf.Floor(time).ToString();

        if (timer.text == "10")
        {
            perdiste.SetActive(true);
            iscountign = false;
            timer.text = "0";

        }

        if (contequipoAzul> contequipoRojo)
        {
            
            perdio.text = "Ganador, equipo AZUL";
        }
        if (contequipoAzul < contequipoRojo)
        {
            perdio.text = "Ganador, equipo ROJO";

        }
        if (contequipoAzul == contequipoRojo)
        {
            perdio.text = "EMPATE";

        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "azul" && contequipoRojo < 5 && contequipoAzul < 5)
        {

            Debug.Log("Contacto");
            transform.position = new Vector3(631.7f, 15.99f, -2491.7f);
            contequipoRojo++;
            gol.text = "";
            gol.text = (contequipoAzul + " : " + contequipoRojo);
            Debug.Log(contequipoRojo + "   " + contequipoAzul);
            player1.transform.position = new Vector3(635.2f, 17.7f, -2538.5f);
            player1.transform.eulerAngles = new Vector3(-88.40401f, 0, 0);
            player2.transform.position = new Vector3(635.38f, 17.7f, -2442.99f);
            player2.transform.eulerAngles = new Vector3(-89.855f, 0, 184.868f);


        }
        else if (contequipoAzul == 5)
        {
            panel.SetActive(true);
            ganador.text = ("Ganador = EQUIPO AZUL!");

        }

        if (col.gameObject.tag == "rojo" && contequipoRojo < 5 && contequipoAzul < 5)
        {

            Debug.Log("Contacto");
            transform.position = new Vector3(631.7f, 15.99f, -2491.7f);
            contequipoAzul++;
            gol.text = "";
            gol.text = (contequipoAzul + " : " + contequipoRojo);
            player1.transform.position = new Vector3(635.2f, 17.7f, -2538.5f);
            player1.transform.eulerAngles = new Vector3(-88.40401f, 0, 0);
            player2.transform.position = new Vector3(635.38f, 17.7f, -2442.99f);
            player2.transform.eulerAngles = new Vector3(-89.855f, 0, 184.868f);

        }
        else if (contequipoRojo == 5)
        {
            panel.SetActive(true);
            ganador.text = ("Ganador = EQUIPO ROJO!");

        }


    }
}
