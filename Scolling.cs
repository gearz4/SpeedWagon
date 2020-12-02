using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scolling : MonoBehaviour
{
    float scollspeed = -20f;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * scollspeed, 20);
        transform.position = startPos + Vector2.right * newPos;
    }
}
