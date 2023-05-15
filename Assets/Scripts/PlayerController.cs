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
        // transform.position += vec3 * movePower *Time.deltaTime;    // Time.deltaTime �������Ӵ� �ɸ��� �ð�
        // transform.Translate(vec3 * movePower * Time.deltaTime);  // ���� �ٶ󺸴� ������ �������θ� �����δ�.
        // transform.Translate(vec3 * movePower * Time.deltaTime, Space.Self);  // ������Ʈ �ձ���
        // transform.Translate(vec3 * movePower * Time.deltaTime, Space.World);  // ������� ������
        // rb.AddForce(vec3 * movePower, ForceMode.Impulse);
        
    }
    private void Rotate()
    {
        transform.Rotate(Vector3.up, vec3.x * rotateSpeed * Time.deltaTime);
        // transform.Rotate(Vector3.up, vec2.x * rotateSpeed * Time.deltaTime, Space.Self);// ������Ʈ �ձ���
        // transform.Rotate(Vector3.up, vec2.x * rotateSpeed * Time.deltaTime, Space.World);// ������� ������
    }

    private void LookAt()
    {
        // transform.LookAt(new Vector3(0, 0, 0)); // ��ǥ��ġ�� �����ϸ� �׹��⸸ �ٶ󺻴�.
    }
    // <Quarternion & Euler>
    // Quarternion	: ����Ƽ�� ���ӿ�����Ʈ�� 3���� ������ �����ϰ� �̸� ���⿡�� �ٸ� ���������� ��� ȸ������ ����
    //				  �������� ȸ������ ������ ������ �߻����� ����
    // EulerAngle	: 3���� �������� ���������� ȸ����Ű�� ���
    //				  ������������ ������ ������ �߻��Ͽ� ȸ���� ��ġ�� ���� ���� �� ����
    // ������		: ���� �������� ������Ʈ�� �� ȸ�� ���� ��ġ�� ����

    // Quarternion�� ���� ȸ�������� ����ϴ� ���� ���������� �ʰ� �����ϱ� �����
    // ������ ��� ���ʹϾ� -> ���Ϸ����� -> �������� -> ������Ϸ����� -> ������ʹϾ� �� ���� ������ ��� ���ʹϾ��� �����
    private void Rotation()
    {
        // Ʈ�������� ȸ������ Euler���� ǥ���� �ƴ� Quaternion�� �����
        transform.rotation = Quaternion.identity;

        // Euler������ Quaternion���� ��ȯ
        transform.rotation = Quaternion.Euler(0, 90, 0);
        // Vector3 trans = transform.rotation.ToEulerAngles();     // �ݴ�� Quaternion�� Euler��

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
