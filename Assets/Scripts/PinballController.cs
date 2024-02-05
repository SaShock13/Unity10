using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinballController : MonoBehaviour
{
    [SerializeField]
    Rigidbody rightBumper;
    [SerializeField]
    Rigidbody leftBumper;
    public float torqueForce;

    private void Update()
    {
        if (Input.GetKey("]"))
        {
            rightBumper.AddRelativeTorque(Vector3.up * torqueForce,ForceMode.Acceleration);
        }
        if (Input.GetKey("q"))
        {
            leftBumper.AddRelativeTorque(Vector3.up * torqueForce * -1, ForceMode.Impulse);
        }
    }
}
