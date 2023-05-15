using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletMove : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float bulletSpeed;

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
}
