using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    [SerializeField]
    private Transform mainCamPos;

    [SerializeField]
    private float backgroundMovespeed;
    private float directionX;

    [SerializeField]
    private float offsetByX = 13;

    private void Update()
    {
        directionX = Input.GetAxis("Horizontal") * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + directionX, transform.position.y);

        if (transform.position.x - mainCamPos.position.x < -offsetByX)
            transform.position = new Vector2(mainCamPos.position.x + offsetByX, transform.position.y);

        else if (transform.position.x - mainCamPos.position.x > offsetByX)
            transform.position = new Vector2(mainCamPos.position.x - offsetByX, transform.position.y);
    }
}
