using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TankMove : MonoBehaviour
{

    private Vector3 vect3;

    [SerializeField]
    private float movePower;
    [SerializeField]
    private float turnPower;

    private void Update()
    {
        Move();
        Rotate();
    }
    private void Move()
    {
        transform.Translate(vect3 * movePower * Time.deltaTime);
    }
    private void Rotate()
    {
        transform.Rotate(Vector3.up, vect3.x * turnPower * Time.deltaTime);
    }
    private void OnMove(InputValue value)
    {
        vect3.x = value.Get<Vector2>().x;
        vect3.z = value.Get<Vector2>().y;
    }
}
