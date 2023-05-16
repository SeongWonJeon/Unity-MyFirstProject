using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private GameObject Explosion;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        // Ʈ�������� �չ������� �ҷ��� �ӵ���ŭ�� �ӵ���ŭ ���ư���.
        rb.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(Explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
