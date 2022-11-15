using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushPlayer : MonoBehaviour
{
    public static bool eCanPush;
    public float dist;
    // public static bool Pushing;
    [SerializeField] public float setForce;
    [SerializeField] public Transform player;

    private void Start()
    { 
        eCanPush = false;
        // Pushing = false;
    }

    private void Update()
    {
    }

    // IEnumerator Aipush(Collider player)
    // {
    //     if (player.gameObject.tag=="Player")
    //     {
    //         print("Ai Pushing!");
    //         //Pushing = true;
    //         GetComponent<Rigidbody>().AddForce(Vector3.back * setForce);
    //         //GetComponent<Rigidbody>().AddForce(player.position * setForce);
    //         //GetComponent<Rigidbody>().AddForce(new Vector3);
    //         // ResetPush();
    //     }
    //
    //     //Instantiate(transform.position, transform.rotation);
    //
    //    
    //     // GetComponent<MeshRenderer>().enabled = false;
    //     // GetComponent<Collider>().enabled = false;
    //
    //     yield return new WaitForSeconds(2);
    // }

    public void ResetPush()
    {
        eCanPush = false;
        //Pushing = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //print("stay P");
            eCanPush = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //print("exit P");
            eCanPush = false;
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
