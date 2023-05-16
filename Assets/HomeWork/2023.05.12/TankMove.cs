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
    // OnMove       입력 input
    // Move         처리 controller
    // Onmoved      데이터 model + 이벤트
    private void Move()
    {
        // vect3.z = value.Get<Vector2>().y 을 저장한 값을 모두 곱해주고 y의 방향으로만 움직이도록
        transform.Translate(Vector3.forward * vect3.z * movePower * Time.deltaTime, Space.Self);
    }
    private void Rotate()
    {
        // 오브젝트의 좌표값의 y축을 기준으로 회전을 할 수 있도록
        transform.Rotate(Vector3.up, vect3.x * turnPower * Time.deltaTime, Space.Self);
    }
    
    private void OnMove(InputValue value)
    {
        vect3.x = value.Get<Vector2>().x;
        vect3.z = value.Get<Vector2>().y;
    }

    private Coroutine bulletRoutine;
    private void OnFire(InputValue value)
    {
        // 프리팹을 씬에 새로운 게임오브잭트로 만들어주는것
        GameObject obj = Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);// 아래와 똑같다
        // Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
        // obj.transform.position = transform.position;
        // obj.transform.rotation = transform.rotation;
    }

    IEnumerator BulletmakeRoutine()
    {
        // 바로 실행되지 않고 백그라운드에서 돌아가고 있는 걸 불러오는 형식
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
            // 눌렀을 때
            Debug.Log("누를 때");
            bulletRoutine = StartCoroutine(BulletmakeRoutine());
        }
        else
        {
            // 땠을 때
            Debug.Log("땠을 때");
            StopCoroutine(bulletRoutine);
        }
    }
}
