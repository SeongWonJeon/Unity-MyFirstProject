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
    // 움직이는 방향을 forward로 해서 앞으로만 움직이지만 아래에있는 Rotate로 회전을 할 수 있도록 만들었음
    private  void Move()
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
    // canFire가 눌리거나 true여야만 발사가능
    private void OnFire(InputValue value)
    {
        if (value.isPressed && canFire)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            StartCoroutine(WaitForIt());
        }
        
    }
    // Coroutine을 사용하여 WaitForIt함수를 만들고 coolDownTime만큼의 시간이 지나면 canfire를 ture로 전환
    IEnumerator WaitForIt()
    {
        canFire = false;
        yield return new WaitForSeconds(coolDownTime);
        canFire = true;
    }
}
