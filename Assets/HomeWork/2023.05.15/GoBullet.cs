using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] public float bulletSpeed;
    [SerializeField] private GameObject Explosion;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rb.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
