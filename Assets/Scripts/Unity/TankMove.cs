using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMove : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody characterRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        characterRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxisRaw("Horizontal");
        float vAxis = Input.GetAxisRaw("Vertical");

        Vector3 inputDir = new Vector3(hAxis, 0, vAxis).normalized;

        characterRigidbody.velocity = inputDir * speed;

        transform.LookAt(transform.position + inputDir);
    }
}
