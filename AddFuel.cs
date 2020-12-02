using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFuel : MonoBehaviour {

    public CarController carController;
    public AudioSource getFuel;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        getFuel.Play();
        carController.fuel = 1;
        
        Destroy(gameObject);
    }
}
