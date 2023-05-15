using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBullet : MonoBehaviour
{
    private Rigidbody rb;
    public float bulletSpeed;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.velocity = Vector3.forward * bulletSpeed;
        Destroy(gameObject, 5f);
    }
}
