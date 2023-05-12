using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public float ffm;
    // Start is called before the first frame update
    void Start()
    {
        rb.AddForce(Vector3.up * ffm, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
