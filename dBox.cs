using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dBox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Car")
        {
            FindObjectOfType<CarController>().fuel = 0;
        }
    }
}
