using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menu111 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width / 2+200, Screen.height / 2-150, 300, 300), "Beauty&Speed");

        if (GUI.Button(new Rect(Screen.width / 2 + 300, Screen.height / 2 - 100, 100, 25), "Локация №1"))
        {
            SceneManager.LoadScene("Car1");
        }
        if (GUI.Button(new Rect(Screen.width / 2 + 300, Screen.height / 2 - 60, 100, 25), "Локация №2"))
        {
            Application.LoadLevel("scene1-night");
        }

        GUI.Button(new Rect(Screen.width / 2 + 300, Screen.height / 2 - 20, 100, 25), "Гараж");

        if (GUI.Button(new Rect(Screen.width / 2 + 300, Screen.height / 2 +20, 100, 25), "Рекорды"))
        {
            
        }



        if (GUI.Button(new Rect(Screen.width / 2 + 300, Screen.height / 2 + 60, 100, 25), "Выход"))
        {
            Application.Quit();
            
        }
    }
}

