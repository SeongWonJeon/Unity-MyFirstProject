using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BulletForward : MonoBehaviour
{
    private Rigidbody bulletBump;
    [SerializeField] private GameObject bulletExplosion;
    [SerializeField] public float bulletSpeed;
    // 총알의 속도 충돌체
    private void Awake()
    {
        bulletBump = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        bulletBump.velocity = transform.forward * bulletSpeed;
        Destroy(gameObject, 5f);
    }

}
