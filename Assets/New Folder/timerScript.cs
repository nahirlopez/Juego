using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{

    float time = 0;
    public Text timer;
    public GameObject perdiste;
    bool iscountign;
    // Start is called before the first frame update
    void Start()
    {
        iscountign = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (iscountign)
        {
 time += Time.deltaTime;
        }
       
        timer.text = Mathf.Floor(time).ToString();

       if (timer.text == "120")
        {
            perdiste.SetActive(true);
            iscountign = false;
            timer.text = "0";
        }
    }
}
