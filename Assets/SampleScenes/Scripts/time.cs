using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //  string count = 0;
    int i = 0;
    // float ti;
    //   float ti120;
    // float ti180;
    public float GameSeconds;
    public float GameMinutes;
    string sec;
    string min;
    public Text Texttime;

    // Update is called once per frame
    void Update()
    {
        GameObject car = GameObject.FindGameObjectWithTag("Player");

        float dist_stop = 10;
        GameObject stop = GameObject.FindGameObjectWithTag("LineStop");
        dist_stop = Vector3.Distance(stop.transform.position, car.transform.position);
        Debug.Log(dist_stop);

        float dist = 10;
        GameObject start = GameObject.FindGameObjectWithTag("LineStart");
        dist = Vector3.Distance(start.transform.position, car.transform.position);
        Debug.Log(dist);


        if (dist <= 5)
        {
            i = 1;
        }
        if (dist_stop <= 6)
        {

            i = 2;

        }
        if (i == 1)
        {
            GameSeconds = GameSeconds + Time.deltaTime;
            sec = GameSeconds.ToString();
            min = GameMinutes.ToString();
            Texttime.text = "Время " + min + " : " + sec;
            if (GameSeconds >= 60.0f) {
                GameMinutes = GameMinutes + 1.0f;
                GameSeconds = 0.0f;
            }
            if (GameMinutes >= 24) {
                GameMinutes = 0.0f;
            }
        }
        if (i == 2)
        {
           
            Texttime.text = "Финиш  ";
            GameSeconds = 0.0f;
            GameMinutes = 0.0f;

           Texttime.rectTransform.position = new Vector3(590, 500, 0);
          //  Texttime.text = "Финиш!!!";
         //   Texttime.fontSize = 30;
          //  Texttime.fontStyle = FontStyle.Bold;
          //  Texttime.color = new Color(255, 255, 255);


        }

    }
}
