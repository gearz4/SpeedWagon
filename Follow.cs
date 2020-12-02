using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public Transform target;
    private Vector3 offset;
    public float speed;

    public float minY;
    public float maxY;


    // Use this for initialization
    void Start () {
        offset = transform.position - target.position;
        
	}

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;

        if (target != null)
        {
            float clampedY = Mathf.Clamp(target.position.y + 5, minY, maxY);
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x, clampedY), speed);
            offset = transform.position - target.position;

        }

    }   
}
