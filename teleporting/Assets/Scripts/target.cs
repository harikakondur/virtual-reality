using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    public float speed = 1.19f;
    public Vector3 pointA = new Vector3(0, 0, 3);
    public Vector3 pointB = new Vector3(0, 3, 3);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Each frame update the transform.position
	    // transform.position = new Vector3(0f, 0f, 0f);
        //PingPong between 0 and 1
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);

    }

     void OnCollisionEnter(Collision collision) {
        Destroy(gameObject);
    }
}
