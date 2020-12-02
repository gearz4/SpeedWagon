using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam2 : MonoBehaviour
{
    [SerializeField]
    private Transform carCarRTor;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            carCarRTor.position.x, transform.position.y, transform.position.z);
    }
}
