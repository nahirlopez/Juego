using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject scriptmenu;
    Menuingame menuingame;
   float golesrojos;
   float golesazules;
    // Start is called before the first frame update
    void Start()
    {
        menuingame = scriptmenu.GetComponent<Menuingame>();
        golesrojos = 
        golesazules = 
        print("golesrojos: " + golesrojos + " golesazules: " + golesazules);
    }

    // Update is called once per frame
    void Update()
    {

        if ()
        {
            string texto = "Gano el";
            string player = "equipo azul";

            if (golesrojos > golesazules)
            {
                player = "equipo rojo";
            }
            else if (golesrojos == golesazules)
            {
                texto = "Hubo un empate";
                player = "no gano nadie";
            }

            menuingame.ShowMenu(texto + "\n" + player);

        }
    }
}