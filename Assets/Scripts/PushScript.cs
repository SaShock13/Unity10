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
    // Start is called before the first frame update
    void Start()
    {
        
        joint = GetComponent<SpringJoint>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("z")) 
        {           
            joint.spring = 0;
            rb.AddForce(Vector3.forward * pushForce, ForceMode.Force);  
        }
        if (Input.GetKeyUp("z"))
        {
            joint.spring = 1000;
        }
        //vector3 = transform.position;
        //vector3.y = floor.transform.position.y + 1;
        //transform.position = vector3;
    }
}
