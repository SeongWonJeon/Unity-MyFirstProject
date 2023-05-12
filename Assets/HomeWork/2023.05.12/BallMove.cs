using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallMove : MonoBehaviour
{
    [SerializeField]
    private float movePower;
    [SerializeField]
    private float jumpPower;
    private Rigidbody rb;
    private Vector3 moveDir;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        rb.AddForce(moveDir * movePower, ForceMode.Force);
    }
    private void Jump()
    {
        Debug.Log("��������");
        rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
    private void OnMove(InputValue value)
    {
        moveDir.x = value.Get<Vector2>().x;
        moveDir.z = value.Get<Vector2>().y;
    }
    private void OnJump(InputValue value)
    {
        Jump();
    }
}
