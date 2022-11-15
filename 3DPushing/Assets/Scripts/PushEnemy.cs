using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushEnemy : MonoBehaviour
{
    public static bool CanPush;
    // public static bool Pushing;
    [SerializeField] public float setForce;
    [SerializeField] public Transform player;

    private void Start()
    { ;
        CanPush = false;
        // Pushing = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && CanPush)
        {
            print("Pushing!");
            //Pushing = true;
            GetComponent<Rigidbody>().AddForce(Vector3.back * setForce);
            //GetComponent<Rigidbody>().AddForce(Vector3 * setForce);
            //GetComponent<Rigidbody>().AddForce(new Vector3);
            // ResetPush();
        }
    }

    public void ResetPush()
    {
        CanPush = false;
        //Pushing = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Playerhand")
        {
            print("stay");
            CanPush = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Playerhand")
        {
            print("exit");
            CanPush = false;
        }
    }
    
    
    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.tag == "Playerhand")
    //     {
    //         GetComponent<Rigidbody>().AddForce(Vector3.back * 1000);
    //     }
    // }
}
