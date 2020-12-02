using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveFuel : MonoBehaviour
{
    public Animator fualAnimation;
    public Image fual;

    // Start is called before the first frame update
    void Start()
    {
        fualAnimation = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if(CarController.instance.movement > 0 || CarController.instance.movement < 0)
        {
            fualAnimation.Play("Fual Blinking");
        }
        else if (CarController.instance.movement == 0)
        {
            fualAnimation.Play("Fual");
        }
    }
}

