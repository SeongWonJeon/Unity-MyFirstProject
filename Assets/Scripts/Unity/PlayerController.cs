using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Vector3 vec3;
    // private Rigidbody rb;

    [SerializeField]
    private float movePower;
    [SerializeField]
    private float rotateSpeed;
    [SerializeField]
    private float jumpPower;

    private void Awake()
    {
        // rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        // Move();
        Rotate();
        // LookAt();
    }
    private void Move()
    {
        // transform.position += vec3 * movePower *Time.deltaTime;    // Time.deltaTime 한프레임당 걸리는 시간
        // transform.Translate(vec3 * movePower * Time.deltaTime);  // 내가 바라보는 방향을 기준으로만 움직인다.
        // transform.Translate(vec3 * movePower * Time.deltaTime, Space.Self);  // 오브젝트 앞기준
        // transform.Translate(vec3 * movePower * Time.deltaTime, Space.World);  // 월드기준 움직임
        // rb.AddForce(vec3 * movePower, ForceMode.Impulse);
        
    }
    private void Rotate()
    {
        transform.Rotate(Vector3.up, vec3.x * rotateSpeed * Time.deltaTime);
        // transform.Rotate(Vector3.up, vec2.x * rotateSpeed * Time.deltaTime, Space.Self);// 오브젝트 앞기준
        // transform.Rotate(Vector3.up, vec2.x * rotateSpeed * Time.deltaTime, Space.World);// 월드기준 움직임
    }

    private void LookAt()
    {
        // transform.LookAt(new Vector3(0, 0, 0)); // 목표위치를 설정하면 그방향만 바라본다.
    }
    // <Quarternion & Euler>
    // Quarternion	: 유니티의 게임오브젝트의 3차원 방향을 저장하고 이를 방향에서 다른 방향으로의 상대 회전으로 정의
    //				  기하학적 회전으로 짐벌락 현상이 발생하지 않음
    // EulerAngle	: 3축을 기준으로 각도법으로 회전시키는 방법
    //				  직관적이지만 짐벌락 현상이 발생하여 회전이 겹치는 축이 생길 수 있음
    // 짐벌락		: 같은 방향으로 오브젝트의 두 회전 축이 겹치는 현상

    // Quarternion을 통해 회전각도를 계산하는 것은 직관적이지 않고 이해하기 어려움
    // 보통의 경우 쿼터니언 -> 오일러각도 -> 연산진행 -> 결과오일러각도 -> 결과쿼터니언 과 같이 연산의 결과 쿼터니언을 사용함
    private void Rotation()
    {
        // 트랜스폼의 회전값은 Euler각도 표현이 아닌 Quaternion을 사용함
        transform.rotation = Quaternion.identity;

        // Euler각도를 Quaternion으로 변환
        transform.rotation = Quaternion.Euler(0, 90, 0);
        // Vector3 trans = transform.rotation.ToEulerAngles();     // 반대로 Quaternion을 Euler로

        transform.position = new Vector3(0, 0, 0);
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    private void Jump1()
    {
        // rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    }
    
    private void OnMove(InputValue value)
    {
        vec3.x = value.Get<Vector2>().x;    
        vec3.z = value.Get<Vector2>().y;

    }
    private void OnJump(InputValue value)
    {
        Jump1();
    }
}
