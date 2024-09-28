using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAI : MonoBehaviour
{

    [SerializeField]
    private float move_speed = 50f;
    private GameObject playerTarget;

    public GameObject BulletTemplate;
    public float shootPower = 1000f;


    private float fireRate = 2f;
    private float nextFire = 0f;

  
    private void OnTriggerEnter(Collider other){ //can be triggered by anything that has a collider and rigid body
        playerTarget = other.gameObject;
    }

    void Update()
    {
        //only move forward when we have a player target

        if (playerTarget!= null){
            //orients it towards the player
            transform.LookAt(playerTarget.transform.position);
            // transform.position+= transform.forward * move_speed * Time.deltaTime;

            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;

                GameObject newBullet = Instantiate(BulletTemplate, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootPower);
            }
        
        }   
    }
}
