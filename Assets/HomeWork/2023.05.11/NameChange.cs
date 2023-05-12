using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameChange : MonoBehaviour
{
    public GameObject obj;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        obj.name = "player";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
