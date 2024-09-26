using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class raycastTeleport : MonoBehaviour
{
    [SerializeField]
    private GameObject playerOrigin;
    [SerializeField]
    private LayerMask teleportMask;
    [SerializeField]
    private InputActionReference teleportButtonPress;

    void Start(){
        teleportButtonPress.action.performed += DoRayCast;
    }


    void DoRayCast(InputAction.CallbackContext __) {
        RaycastHit hit;
        bool didHit = Physics.Raycast(
            transform.position,
            transform.forward,
            out hit,
            Mathf.Infinity,
            teleportMask);

        if (didHit) {
            // Debug.Log(hit.collider.gameObject.name);
            playerOrigin.transform.position = hit.collider.gameObject.transform.position;
        }
    } 
}

