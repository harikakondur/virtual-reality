using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeController : MonoBehaviour
{
    public GameObject rightHandReference;

    // Create a variable to store the position of the controller from the last frame
    Vector3 previousRightHandPosition = new Vector3(0,0,0);

    void Update() {
        // Get the distance between frames on the hand
        float distance = Vector3.Distance(previousRightHandPosition, rightHandReference.transform.position);
        // Time.timeScale = 0.5f;


        // 1f in unity is a meter
        if (distance > 0.007f){ 
            Time.timeScale = 1.0f; 
        }
        else
        {
            Time.timeScale = 0.2f;
        }

        // dont forget to set the previous position
        previousRightHandPosition = rightHandReference.transform.position;
    }
}
