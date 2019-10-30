using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof(CarController))]
    public class StartPlay : MonoBehaviour
    {
        // Start is called before the first frame update



        void Start()
        {
            // text = GameObject.FindGameObjectWithTag("Canvas").gameObject.GetComponentInChildren<Text>();
            //text.text = "!!!";

            //m_CarController = GetComponent<CarController>();
            //car = new CarController();


        }
       
        // Update is called once per frame
        void Update()
        {


            float a = 0;
            a = Mathf.Round(CarController.Instance.CurrentSpeed);
            GetComponent<Text>().text = a.ToString() + " Км/ч";



        }
    }
}
