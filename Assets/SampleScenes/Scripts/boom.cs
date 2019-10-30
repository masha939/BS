using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boom : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Textboom;
    public float GameSeconds;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject car = GameObject.FindGameObjectWithTag("Player");

        float boom = 10;
        GameObject stena = GameObject.FindGameObjectWithTag("Stena");
        boom = Vector3.Distance(stena.transform.position, car.transform.position);
        Debug.Log(boom);

        if (boom <= 10)
        {
            GameSeconds = GameSeconds + Time.deltaTime;
            Textboom.text = "лох";
           // if (GameSeconds >= 5.0f)
            //{
           //     Textboom.text = " ";
          //      GameSeconds = 0.0f;
          //  }
        }
    }
}
