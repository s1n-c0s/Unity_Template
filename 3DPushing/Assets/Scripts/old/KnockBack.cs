using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
    [SerializeField]
    private float knockbackStrength;
    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();

        if (rb!=null)
        {
            Vector3 dir = collision.transform.position - transform.position;
            dir.y = 0;

            rb.AddForce(dir.normalized * knockbackStrength, ForceMode.Impulse);
        }
    }
}
