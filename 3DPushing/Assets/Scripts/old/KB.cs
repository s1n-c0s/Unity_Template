using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KB : MonoBehaviour
{
    public static bool CanPush;
    public static bool Pushing;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            print("enter");
            CanPush = true;
        }
    }

    private void Start()
    {
        CanPush = false;
        Pushing = false;
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Z) && CanPush)
        {
            print("Attack");
            Pushing = true;
            ResetPush();
        }
    }

    public void ResetPush()
    {
        CanPush = false;
        Pushing = false;
    }

    // private void OnTriggerStay(Collider other)
    // {
    //     if (other.gameObject.tag == "Enemy")
    //     {
    //         print("stay");
    //     }
    // }
    
    // private void OnTriggerExit(Collider other)
    // {
    //     if (other.gameObject.tag == "Enemy")
    //     {
    //         print("exit");
    //     }
    // }
}
