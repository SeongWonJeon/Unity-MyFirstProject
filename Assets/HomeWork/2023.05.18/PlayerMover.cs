using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSpeed;
    private Vector3 movePoint;


    private void Update()
    {
        Move();
        Rotate();
    }
    // 움직이는 방향을 forward로 해서 앞으로만 움직이지만 아래에있는 Rotate로 회전을 할 수 있도록 만들었음
    private void Move()
    {
        transform.Translate(Vector3.forward * movePoint.z * moveSpeed * Time.deltaTime, Space.Self);
    }
    // 회전할 수 있도록
    private void Rotate()
    {
        transform.Rotate(Vector3.up, movePoint.x * turnSpeed * Time.deltaTime, Space.Self);
    }

    private void OnMoveWASD(InputValue value)
    {
        movePoint.x = value.Get<Vector2>().x;
        movePoint.z = value.Get<Vector2>().y;
    }
}
