﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_day : MonoBehaviour
{
    [SerializeField] GameObject m_directlight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        m_directlight.transform.Rotate(new Vector3(0.03f, 0, 0));
    }
}
