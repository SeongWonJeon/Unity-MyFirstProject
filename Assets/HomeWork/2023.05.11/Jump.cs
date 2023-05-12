using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public float ffm;
    void Start()
    {
        rb.AddForce(Vector3.up * ffm, ForceMode.Impulse);
    }
}
