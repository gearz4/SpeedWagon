using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax2 : MonoBehaviour
{
    private float length, startpos;
    public GameObject camFow;
    public float parallaxEff;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float temp = (camFow.transform.position.x * (1 - parallaxEff));
        float dist = (camFow.transform.position.x * parallaxEff);
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
