using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushScript : MonoBehaviour
{
    Rigidbody rb;
    SpringJoint joint;
    [SerializeField]
    float pushForce;
    Vector3 vector3;
    [SerializeField]
    GameObject floor;
    
    void Start()
    {
        joint = GetComponent<SpringJoint>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        PusherListener();
    }

    void PusherListener()
    {
        if (Input.GetKey("z"))
        {
            joint.spring = 0;
            rb.AddRelativeForce(Vector3.forward * pushForce, ForceMode.Force);
        }
        if (Input.GetKeyUp("z"))
        {
            joint.spring = 1000;
        }
    }
}
