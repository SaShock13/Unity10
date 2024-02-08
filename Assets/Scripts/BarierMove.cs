using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class BarierMove : MonoBehaviour
{
    bool isForward = true;
    public float speed;
    Vector3 newPosition;
    [SerializeField]
    float maxPosition;
    [SerializeField]
    float minPosition; 
   
    void Update()
    {
        MoveBarier();
    }

    void MoveBarier()
    {
        if (isForward)
        {
            newPosition = transform.position + (Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= maxPosition)
            {
                isForward = false;
            }
        }
        else
        {
            Debug.Log("right");
            newPosition = transform.position + (Vector3.left * speed * Time.deltaTime);

            if (transform.position.x <= minPosition)
            {
                isForward = true;
            }
        }
        transform.position = newPosition;
    }
}
