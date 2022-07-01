using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menuingame : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI parrafo;

    public void ShowMenu(string p)
    {
        canvas.SetActive(!canvas.activeSelf);
        parrafo.text = p;
    }
}