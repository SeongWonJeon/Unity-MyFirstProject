using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMove : MonoBehaviour
{

    private Vector3 vect3;

    [SerializeField] private float movePower;
    [SerializeField] private float turnPower;
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float repeatTime;

    private void Update()
    {
        Move();
        Rotate();
    }
    private void Move()
    {
        // vect3.z = value.Get<Vector2>().y �� ������ ���� ��� �����ְ� y�� �������θ� �����̵���
        transform.Translate(Vector3.forward * vect3.z * movePower * Time.deltaTime);
    }
    private void Rotate()
    {
        // ������Ʈ�� ��ǥ���� y���� �������� ȸ���� �� �� �ֵ���
        transform.Rotate(Vector3.up, vect3.x * turnPower * Time.deltaTime);
    }
    
    private void OnMove(InputValue value)
    {
        vect3.x = value.Get<Vector2>().x;
        vect3.z = value.Get<Vector2>().y;
    }

    private Coroutine bulletRoutine;
    private void OnFire(InputValue value)
    {
        // �������� ���� ���ο� ���ӿ�����Ʈ�� ������ִ°�
        // GameObject obj = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);// �Ʒ��� �Ȱ���
        // Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        // obj.transform.position = transform.position;
        // obj.transform.rotation = transform.rotation;
    }

    IEnumerator BulletmakeRoutine()
    {
        // �ٷ� ������� �ʰ� ��׶��忡�� ���ư��� �ִ� �� �ҷ����� ����
        while(true)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            yield return new WaitForSeconds(repeatTime);
        }
    }

    private void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            // ������ ��
            Debug.Log("���� ��");
            bulletRoutine = StartCoroutine(BulletmakeRoutine());
        }
        else
        {
            // ���� ��
            Debug.Log("���� ��");
            StopCoroutine(bulletRoutine);
        }
    }
}
