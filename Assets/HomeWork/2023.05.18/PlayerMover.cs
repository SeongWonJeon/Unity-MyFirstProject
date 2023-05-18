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
    // �����̴� ������ forward�� �ؼ� �����θ� ���������� �Ʒ����ִ� Rotate�� ȸ���� �� �� �ֵ��� �������
    private void Move()
    {
        transform.Translate(Vector3.forward * movePoint.z * moveSpeed * Time.deltaTime, Space.Self);
    }
    // ȸ���� �� �ֵ���
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
