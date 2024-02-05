using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField]
    GameObject ball;    
    Vector3 shift;
    Vector3 newPosition;

    private void Start()
    {
        shift = new Vector3(30, 0, 0);
        newPosition = ball.transform.position + shift;
        transform.position = newPosition;
        transform.LookAt(ball.transform.position);
    }

    private void Update()
    {
        newPosition = ball.transform.position+shift;
        transform.position =  newPosition;
    }

}
