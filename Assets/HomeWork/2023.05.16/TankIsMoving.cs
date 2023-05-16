using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankIsMoving : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float coolDownTime;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private GameObject bulletPrefab;
    private Vector3 movePoint;
    private bool canFire = true;

    private void Update()
    {
        Move();
        Rotate();
    }
    // �����̴� ������ forward�� �ؼ� �����θ� ���������� �Ʒ����ִ� Rotate�� ȸ���� �� �� �ֵ��� �������
    private  void Move()
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
    // canFire�� �����ų� true���߸� �߻簡��
    private void OnFire(InputValue value)
    {
        if (value.isPressed && canFire)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            StartCoroutine(WaitForIt());
        }
        
    }
    // Coroutine�� ����Ͽ� WaitForIt�Լ��� ����� coolDownTime��ŭ�� �ð��� ������ canfire�� ture�� ��ȯ
    IEnumerator WaitForIt()
    {
        canFire = false;
        yield return new WaitForSeconds(coolDownTime);
        canFire = true;
    }
}
