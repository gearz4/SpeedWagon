﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerSlow : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            CarController.instance.CarSlow();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        CarController.instance.CarNotSlow();
    }
}
